using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            EnemyTank tank = new EnemyTank();
            EnemyRobot robo = new EnemyRobot();
            EnemyAttacker robotAdapter = new EnemyRobotAdapter(robo);
            robo.reactToHuman("Me");
            robo.walkForward();

            tank.assignDriver("Frank");
            tank.driveFW();

            robotAdapter.assignDriver("Gaby");
            robotAdapter.driveFW();

        }
    }
}
