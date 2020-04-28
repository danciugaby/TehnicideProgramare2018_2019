using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class UFOShipBuilding : ShipBuilding

    {
        public override Ship makeShip(string type)
        {
            Ship ufoship = null;

            if (type == "UFO")
            {
                ShipFactory factory = new ShipFactory();

                ufoship = factory.makeShip("U");
                ufoship.Name = "UFO new Ship";
            }
            if (type == "BIG UFO")
            {
                ShipFactory factory = new ShipFactory();

                ufoship = factory.makeShip("B");
                ufoship.Name = "UFO Boss Ship";
            }


            return ufoship;
        }
    }
}
