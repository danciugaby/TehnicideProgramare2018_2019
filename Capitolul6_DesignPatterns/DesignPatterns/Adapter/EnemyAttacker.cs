using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface EnemyAttacker
    {
        void fireWeapon();
        void driveFW();
        void assignDriver(String name);
    }
}
