using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLog;

namespace Scheduler
{
    class MainLogger
    {
        static Logger logger = null;

        private MainLogger(){}

        public static Logger Instance 
        {
            get
            {
                if (logger == null)
                {
                    logger = LogManager.GetCurrentClassLogger();
                }

                return logger;
            }
        }

    }
}
