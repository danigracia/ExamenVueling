using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Examen.Bussines.Contract.Logic;
using Examen.Common.Contract.Logic.LoggerAdapter;
using Examen.Common.Logic;
using Examen.Common.Logic.LoggerAdapter;
using Examen.DataAccesa.Contract.WebServices;
using Examen.DataAccess.Contract.Redis;
using Examen.DataAccess.Redis;

namespace Examen.Bussines.Logic
{
    public class DataRatesBusinessLogic : IDataRatesBl
    {
        private readonly IGetData getData;
        private readonly ISetRedis setDataRates;
		private readonly ILogger logger = Log4NetConfiguration.CreateInstanceClassLog(MethodBase.GetCurrentMethod().DeclaringType);
		private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


		public DataRatesBusinessLogic(IGetData getData, ISetRedis setDataRates)
        {
			logger.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name);
			this.getData = getData;
            this.setDataRates = setDataRates;
        }
        public Task<List<DataRates>> GetDataRates()
        {
			logger.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name);
			return getData.GetDataRates();
        }

		public List<DataRates> SetDataRates(List<DataRates> dataRates, string key)
		{
			logger.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name);
			return setDataRates.AddRates(dataRates, key);
		}

	}
}
