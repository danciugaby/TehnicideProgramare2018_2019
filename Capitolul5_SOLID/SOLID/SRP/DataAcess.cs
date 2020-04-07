using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class DataAccess
    {
        public static void InsertData()
        {
            Console.WriteLine("... Inserting data ...");
            //Console.WriteLine("Logged Time:" + DateTime.Now.ToLongTimeString() + " Log  Data insertion completed successfully");
            Logger.WriteLog("Data insertion completed successfully");
        }
    }
}
