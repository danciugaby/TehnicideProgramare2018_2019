using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Bird : Animal  // Flyable //functioneaza dar trebuie implementat de fiecare clasa
    {

        public Bird()
        {
            FlyCapability = new ItFlyes();
        }

        /*
        string Flyable.fly()
        {
            return "birds fly fast";
        }
        */
    }
}
