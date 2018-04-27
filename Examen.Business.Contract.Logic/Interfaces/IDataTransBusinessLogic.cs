using Examen.Common.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Business.Contract.Logic
{
	public interface IDataTransBusinessLogic
	{
		Task<List<DataTrans>> GetDataTrans();
		List<DataTrans> SetDataTrans(List<DataTrans> dataTrans, string key);
	}
}
