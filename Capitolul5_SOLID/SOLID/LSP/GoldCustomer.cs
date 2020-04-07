using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    class GoldCustomer :Customer
    {
        public GoldCustomer()
        {
            base.type = "gold";
        }
    }
}
