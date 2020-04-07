using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    class EventLogger : ILogger
    {
        public void LogMessage(string a)
        {
            Console.WriteLine("Event {0}", a);
        }
    }
}
