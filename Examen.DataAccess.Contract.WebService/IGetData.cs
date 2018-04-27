using Examen.Common.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Examen.DataAccesa.Contract.WebServices
{
	public interface IGetData
	{
		Task<List<DataTrans>> GetDataTrans();
		Task<List<DataRates>> GetDataRates();
	}
}
