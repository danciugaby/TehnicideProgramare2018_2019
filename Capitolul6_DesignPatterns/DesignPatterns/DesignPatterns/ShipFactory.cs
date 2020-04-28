using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class ShipFactory
    {
        public Ship makeShip(String shipType)
        {
           
            switch (shipType)
            {
                case "U":
                    return new UFOShip();
                case "R":
                    return new RocketShip();
                case "B":
                    return new BigUFOShip();
                default:
                    return null;
            }

        }
    }
}
