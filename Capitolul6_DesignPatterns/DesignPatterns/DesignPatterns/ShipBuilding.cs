using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    abstract class ShipBuilding
    {
        public abstract Ship makeShip(String type);
        public static Ship orderShip(String type)
        {
            ShipBuilding shipbuilding = null;
            switch (type)
            {
                case "UFO":
                    shipbuilding = new UFOShipBuilding();
                    break;
                case "BIG UFO":
                    shipbuilding = new UFOShipBuilding();
                    break;
                case "ROCK":
                    shipbuilding = new RocketShipBuilding();
                    break;
                    //DEFAULT
            }
            //treat missing cases
            Ship newship = shipbuilding.makeShip(type);

            return newship;
           
        }



    }
}
