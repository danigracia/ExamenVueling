using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Common.Contract.Logic.LoggerAdapter
{
    public interface ILogger
    {
        void Info(Object message);
        void Warn(Object message);
        void Debug(Object usuario);
        void Error(Object message);
        void Fatal(Object message);
    }
}