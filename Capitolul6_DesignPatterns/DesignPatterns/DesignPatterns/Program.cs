using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------Factory---------------------------------------

            ShipFactory factory = new ShipFactory();
            List<Ship> ships = new List<Ship>();
            Console.WriteLine("Enter type of ship U / R / B");
            String a = Console.ReadLine();
            Ship s = factory.makeShip(a);
            ships.Add(s);
            Console.WriteLine("Enter type of ship U / R / B");
            a = Console.ReadLine();
            s = factory.makeShip(a);
            ships.Add(s);
            foreach (Ship ship in ships)
                Console.WriteLine(ship);
            ships.Clear();
            //------------------------------------ABSTRACTING FACTORIES---------------------------------------


            ships.Add(ShipBuilding.orderShip("UFO"));
            ships.Add(ShipBuilding.orderShip("BIG UFO"));
            ships.Add(ShipBuilding.orderShip("ROCK"));
            foreach (Ship ship in ships)
                Console.WriteLine(ship);
            Console.ReadLine();

        }
    }
}
