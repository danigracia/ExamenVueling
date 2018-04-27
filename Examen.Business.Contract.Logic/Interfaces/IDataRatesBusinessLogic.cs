using Examen.Common.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Bussines.Contract.Logic
{
    public interface IDataRatesBl
    {
        Task<List<DataRates>> GetDataRates();
        List<DataRates> SetDataRates(List<DataRates> dataRates, string key);
    }
}
