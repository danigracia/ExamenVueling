using Examen.Business.Contract.Logic;
using Examen.Bussines.Contract.Logic;
using Examen.Bussines.Logic;
using Examen.Common.Contract.Logic.LoggerAdapter;
using Examen.Common.Logic;
using Examen.Common.Logic.LoggerAdapter;
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
    public class GenericV2Controller : ApiController
    {
        private readonly IDataRatesBl dataRatesBl;
        private readonly IDataTransBl dataTransBl;
		private readonly ILogger logger = Log4NetConfiguration.CreateInstanceClassLog(MethodBase.GetCurrentMethod().DeclaringType);
		private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        

        public GenericV2Controller(IDataRatesBl dataRatesBl, IDataTransBl dataTransBl)
        {
            this.dataRatesBl = dataRatesBl;
			this.dataTransBl = dataTransBl;
        }
        /// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
        [HttpGet()]
        public IHttpActionResult GetRates()
        {
            logger.Debug(Resources.ResourcesLog.EnterFunction + System.Reflection.MethodBase.GetCurrentMethod().Name);
			return Ok(this.dataRatesBl.GetDataRates());
        }
        /// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
        [HttpGet()]
        public IHttpActionResult GetTrans()
        {
			return Ok(this.dataTransBl.GetDataTrans());
        }
		/// <summary>
		/// 
		/// </summary>
		/// <param name="dataRates"></param>
		/// <returns></returns>
		[HttpPost()]
		public IHttpActionResult SetRates(DataRates dataRates)
		{
			logger.Debug("Inicio: " + System.Reflection.MethodBase.GetCurrentMethod().Name);

			return Ok(this.dataRatesBl.GetDataRates());
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="dataTrans"></param>
		/// <returns></returns>
		[HttpPost()]
		public IHttpActionResult SetTrans(DataTrans dataTrans)
		{
			logger.Debug("Inicio: " + System.Reflection.MethodBase.GetCurrentMethod().Name);

			return Ok(this.dataTransBl.GetDataTrans());
		}
	}
}
