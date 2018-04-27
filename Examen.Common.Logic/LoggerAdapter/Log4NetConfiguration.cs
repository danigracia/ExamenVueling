using Examen.Common.Contract.Logic.LoggerAdapter;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Common.Logic.LoggerAdapter
{
    public static class Log4NetConfiguration
    {
        private static ILogger logger = CreateInstanceClassLog(MethodBase.GetCurrentMethod().DeclaringType);
        public static ILogger CreateInstanceClassLog(Type typeDeclaring)
        {
            var logType = Environment.GetEnvironmentVariable(Resources.ResourcesLog.LogType, EnvironmentVariableTarget.User);
            var key = LeerWebConfig(logType);

            Type t = Assembly.GetExecutingAssembly().GetType(key);

            object[] mParam = new object[] { typeDeclaring };
			return (ILogger)Activator.CreateInstance(t, mParam);
        }
        public static string LeerWebConfig(string key)
        {
            return ConfigurationManager.AppSettings[key];
            
        }
    }
}
