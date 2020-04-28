using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class EnemyRobotAdapter : EnemyAttacker
    {
        EnemyRobot robot;

        public EnemyRobotAdapter(EnemyRobot r)
        {
            robot = r;
        }

        public void assignDriver(string name)
        {
            robot.reactToHuman(name);
        }

        public void driveFW()
        {
            robot.walkForward();
        }

        public void fireWeapon()
        {
            robot.smashWithHands();
        }
    }
}
