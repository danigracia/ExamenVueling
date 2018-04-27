using Examen.Common.Contract.Logic.LoggerAdapter;
using Examen.Common.Logic.LoggerAdapter;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Common.Logic
{
    public static class ConfigurationTools
    {
		public static string GetRedisEndPoint()
        {
			return ConfigurationManager.AppSettings["RedisEndPoint"];
        }
    }
}
