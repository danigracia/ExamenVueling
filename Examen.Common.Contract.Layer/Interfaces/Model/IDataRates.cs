using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Common.Contract.Layer
{
	public interface IDataRates
	{
		string From { get; set; }
		string To { get; set; }
		decimal Rate { get; set; }
	}
}
