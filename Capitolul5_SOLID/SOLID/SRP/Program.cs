using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            DataAccess.InsertData();
            //..other code
            Logger.WriteLog();
            Logger.WriteLog("test message");
        }
    }
}
