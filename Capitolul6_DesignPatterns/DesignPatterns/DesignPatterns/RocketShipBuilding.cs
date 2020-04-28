using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class RocketShipBuilding : ShipBuilding
    {

        public override Ship makeShip(string type)
        {
            Ship rockship = null;
            if (type == "ROCK")
            {
                ShipFactory factory = new ShipFactory();
                rockship = factory.makeShip("R");
                rockship.Speed += ((RocketShip)rockship).GetFirePower();
            }
            //... alte tipuri de racheta
            return rockship;
        }
    }
}
