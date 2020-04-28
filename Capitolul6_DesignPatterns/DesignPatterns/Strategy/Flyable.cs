using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    interface Flyable
    {
        String fly();

    }
    //decuplare
    class ItFlyes : Flyable
    {
        public string fly()
        {
            return "Flying High";
        }
    }
    class CantFly : Flyable
    {
        public string fly()
        {
            return "I can't fly";          

        }
    }



}
