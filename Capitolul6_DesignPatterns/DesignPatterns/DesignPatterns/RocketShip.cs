using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class RocketShip : Ship, Engine
    {
        public RocketShip()
        {
            Name = "Rocket ship";
            Speed = 7;
        }

        public double GetFirePower()
        {
            return 120;
        }
    }
}
