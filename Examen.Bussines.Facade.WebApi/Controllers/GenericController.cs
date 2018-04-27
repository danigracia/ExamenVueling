using Examen.Business.Contract.Logic;
using Examen.Bussines.Contract.Logic;
using Examen.Bussines.Logic;
using Examen.Common.Contract.Logic.LoggerAdapter;
using Examen.Common.Logic;
using Examen.Common.Logic.LoggerAdapter;
using Examen.DataAccess.Contract.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Threading;
using System.Web.Http;

namespace Examen.Bussines.Facade.WebApi.Controllers
{
    public class GenericController : ApiController
    {
        private readonly IDataRatesBl dataRatesBl;
        private readonly IDataTransBusinessLogic dataTransBl;
		private readonly ISetRedis setRedis;
		private readonly IGetRedis getRedis;
		private readonly ILogger logger = Log4NetConfiguration.CreateInstanceClassLog(MethodBase.GetCurrentMethod().DeclaringType);
		private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        

        public GenericController(IDataRatesBl dataRatesBl, IDataTransBusinessLogic dataTransBl, ISetRedis setRedis, IGetRedis getRedis)
        {
            this.dataRatesBl = dataRatesBl;
			this.dataTransBl = dataTransBl;
			this.setRedis = setRedis;
			this.getRedis = getRedis;
        }
		/// <summary>
		/// Get Data from webapi external, but failed connection Get Data from redis
		/// </summary>
		/// <returns>json</returns>
		[HttpGet()]
        public IHttpActionResult GetRates()
        {
            logger.Debug(Resources.ResourcesLog.EnterFunction + System.Reflection.MethodBase.GetCurrentMethod().Name);
			
			try
			{
				var data = this.dataRatesBl.GetDataRates();
				setRedis.AddRates(data.Result, Resources.ResourcesLog.keyRates);
				return Ok(data);
			}
			catch (Exception)
			{
				logger.Debug(Resources.ResourcesLog.FailConnect + System.Reflection.MethodBase.GetCurrentMethod().Name);
				return Ok(getRedis.GetRates(Resources.ResourcesLog.keyRates));
			}
			
        }
		/// <summary>
		/// Get Data from webapi external, but failed connection Get Data from redis
		/// </summary>
		/// <returns>json</returns>
        [HttpGet()]
        public IHttpActionResult GetTrans()
        {
			try
			{
				logger.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name);
				var data = this.dataTransBl.GetDataTrans();
				setRedis.AddTrans(data.Result, Resources.ResourcesLog.keyTrans);
				return Ok(data);
			}
			catch (Exception)
			{
				logger.Debug(Resources.ResourcesLog.FailConnect + System.Reflection.MethodBase.GetCurrentMethod().Name);
				return Ok(getRedis.GetTrans(Resources.ResourcesLog.keyTrans));
			}
		}
		
	}
}
