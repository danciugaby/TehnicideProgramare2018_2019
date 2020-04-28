using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class EnemyTank : EnemyAttacker
    {
        Random r = new Random();
        public void assignDriver(String name)
        {
            Console.WriteLine("Enemy tank is driven by " + name + " soldier ");
        }

        public void driveFW()
        {
            int movement = r.Next(5) + 1;
            Console.WriteLine("Enemy tank moves " + movement + " feet ");
        }


        public void fireWeapon()
        {
            int attackDamage = r.Next(10) + 1;
            Console.WriteLine("Enemy tank does " + attackDamage + " Damage ");
        }
    }
}
