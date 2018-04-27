using Examen.Business.Contract.Logic;
using Examen.Common.Contract.Logic.LoggerAdapter;
using Examen.Common.Logic;
using Examen.Common.Logic.LoggerAdapter;
using Examen.DataAccesa.Contract.WebServices;
using Examen.DataAccess.Contract.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Bussines.Logic
{
	public class DataTransBusinessLogic : IDataTransBusinessLogic
	{
		private readonly IGetData getData;
		private readonly ISetRedis setDataTrans;
		private readonly ILogger logger = Log4NetConfiguration.CreateInstanceClassLog(MethodBase.GetCurrentMethod().DeclaringType);
		private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


		public DataTransBusinessLogic(IGetData getData, ISetRedis setDataTrans)
		{
			logger.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name);
			this.getData = getData;
			this.setDataTrans = setDataTrans;
		}
		public Task<List<DataTrans>> GetDataTrans()
		{
			logger.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name);
			return getData.GetDataTrans();
		}

		public List<DataTrans> SetDataTrans(List<DataTrans> dataTrans, string key)
		{
			logger.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name);
			return setDataTrans.AddTrans(dataTrans, key);
		}

	}
}
