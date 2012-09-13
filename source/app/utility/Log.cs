using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app.utility
{
    public class Log
    {
        public static GetCurrentLoggingBehaviour logging_behaviour = loggerType => { throw new NotImplementedException("Needs to be created during startup ");};

        public static ILog an<T>()
        {
            return logging_behaviour(typeof(T));
        } 
    }

    public interface ILog
    {
    }
}
