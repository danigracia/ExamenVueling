using Examen.Common.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.DataAccess.Contract.Redis
{
    public interface ISetRedis
    {
        List<DataRates> AddRates(List<DataRates> dataRates, string key);
        List<DataTrans> AddTrans(List<DataTrans> dataTrans, string key);
    }
}
