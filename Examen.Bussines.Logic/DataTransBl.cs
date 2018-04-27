using Examen.Business.Contract.Logic;
using Examen.Common.Logic;
using Examen.DataAccesa.Contract.WebServices;
using Examen.DataAccess.Contract.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Bussines.Logic
{
	public class DataTransBl : IDataTransBl
	{
		private readonly IGetData getData;
		private readonly ISetRedis setDataTrans;

		public DataTransBl(IGetData getData, ISetRedis setDataTrans)
		{
			this.getData = getData;
			this.setDataTrans = setDataTrans;
		}
		public Task<List<DataTrans>> GetDataTrans()
		{
			return getData.GetDataTrans();
		}

		public List<DataTrans> SetDataTrans(List<DataTrans> dataTrans, string key)
		{
			return setDataTrans.AddTrans(dataTrans, key);
		}

	}
}
