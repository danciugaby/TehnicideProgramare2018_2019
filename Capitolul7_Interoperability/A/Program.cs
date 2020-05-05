using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 2;
            B.Bridge bridge = new B.Bridge();
            a = bridge.DoubleMyValCaller(a);
        }
    }
}
