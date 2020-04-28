using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class BigUFOShip : Ship, Gun
    {
        public BigUFOShip()
        {
            Name = "Big UFO ship";
            Speed = 100;
        }

        public double GetDamage()
        {
            return 1000;
        }

        public override string ToString()
        {
            return base.ToString() + " Mega Damage " + GetDamage();
        }
    }
}
