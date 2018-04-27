using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Examen.Bussines.Contract.Logic;
using Examen.Common.Logic;
using Examen.DataAccesa.Contract.WebServices;
using Examen.DataAccess.Contract.Redis;
using Examen.DataAccess.Redis;

namespace Examen.Bussines.Logic
{
    public class DataRatesBl : IDataRatesBl
    {
        private readonly IGetData getData;
        private readonly ISetRedis setDataRates;
		
		public DataRatesBl(IGetData getData, ISetRedis setDataRates)
        {
            this.getData = getData;
            this.setDataRates = setDataRates;
        }
        public Task<List<DataRates>> GetDataRates()
        {
			return getData.GetDataRates();
        }

		public List<DataRates> SetDataRates(List<DataRates> dataRates, string key)
		{
			return setDataRates.AddRates(dataRates, key);
		}

	}
}
