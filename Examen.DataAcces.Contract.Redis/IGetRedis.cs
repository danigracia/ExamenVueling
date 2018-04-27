using Examen.Common.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.DataAccess.Contract.Redis
{
    public interface IGetRedis
    {
        List<DataRates> GetRates(string key);
        List<DataTrans> GetTrans(string key);

    }
}
