using Examen.Common.Contract.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Common.Logic
{
    public class DataTrans : IDataTrans
    {
        public string Sku { get; set; }
        public string Amount { get; set; }
        public string Currency { get; set; }
    }
}
