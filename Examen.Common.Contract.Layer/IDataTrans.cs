using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Common.Contract.Logic
{
    public interface IDataTrans
    {
		string Sku { get; set; }
		string Amount { get; set; }
		string Currency { get; set; }
	}
}
