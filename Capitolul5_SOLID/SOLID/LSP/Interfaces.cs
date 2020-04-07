using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    interface IDiscount
    {
        double getDiscount(double TotalSales);
    }


    interface IDatabase
    {
        void Add();
    }
}
