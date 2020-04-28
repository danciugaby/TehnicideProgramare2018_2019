using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class EnemyRobot
    {
        Random r = new Random();

        public void smashWithHands()
        {
            int attackDamage = r.Next(10) + 1;
            Console.WriteLine("Enemy robot does " + attackDamage + " damage with hands ");
        }

        public void walkForward()
        {
            int movement = r.Next(4) + 1;
            Console.WriteLine("Enemy robot walks forward " + movement + " feet ");
        }

        public void reactToHuman(String human)
        {
            Console.WriteLine("Hi " + human + " how are you ");
        }
    }
}

