using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    class Enquiry : IDiscount//Customer
    {
        public /*override*/ double getDiscount(double TotalSales)
        {
            //return base.getDiscount(TotalSales) - 5;
            return TotalSales - 5;
        }
        /*
        public override void Add()
        {
            throw new Exception("Not allowed");
        }
        */
    }
}
