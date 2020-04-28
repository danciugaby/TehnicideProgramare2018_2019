using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Dog : Animal     //can't fly
    {
        Dog(String name)
        {
            Name = name;
        }
        public Dog()
        {
            FlyCapability = new CantFly();
        }
    }
}
