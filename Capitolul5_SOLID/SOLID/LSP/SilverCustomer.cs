using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    class SilverCustomer : Customer
    {
        public SilverCustomer()
        {
            base.type = "silver";
        }
    }
}
