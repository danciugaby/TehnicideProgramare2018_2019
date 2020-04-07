using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class Logger
    {
        public static void WriteLog()
        {
            Console.WriteLine("Logged Time:" + DateTime.Now.ToLongTimeString() + " ... ");
        }
        public static void WriteLog(string message)
        {
            Console.WriteLine("Logged Time:" + DateTime.Now.ToLongTimeString() + " {0} ",message);
        }
    }
}
