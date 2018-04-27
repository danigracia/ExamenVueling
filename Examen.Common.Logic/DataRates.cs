using Examen.Common.Contract.Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Common.Logic
{
	public class DataRates : IDataRates
	{
		public string From { get; set; }
		public string To { get; set; }
		public string Rate { get; set; }
	}
}
