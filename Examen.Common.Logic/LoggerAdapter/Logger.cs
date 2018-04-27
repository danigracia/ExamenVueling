using Examen.Common.Contract.Logic.LoggerAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Common.Logic.LoggerAdapter
{
    public class Logger : ILogger
    {
        private readonly log4net.ILog log;

        public Logger(Type typeDeclaring)
        {
            this.log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public void Debug(object usuario)
        {
            this.log.Debug(usuario.ToString());
        }

        public void Error(object message)
        {
            this.log.Error(message.ToString());
        }

        public void Fatal(object message)
        {
            this.log.Fatal(message.ToString());
        }

        public void Info(object message)
        {
            this.log.Info(message.ToString());
        }

        public void Warn(object message)
        {
            this.log.Warn(message.ToString());
        }
    }
}
