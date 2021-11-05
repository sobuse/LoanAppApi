using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    public interface ILoggerManager
    {
        void LogInfo(string message);
        void logWarn(string message);
        void logDebug(string message);
        void LogError(string message);
    }
}
