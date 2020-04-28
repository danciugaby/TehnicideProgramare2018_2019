using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Animal
    {
        Double speed;
        String name;
        String sound;

        private Flyable flyCapability;

        public double Speed { get => speed; set => speed = value; }
        public string Name { get => name; set => name = value; }
        public string Sound { get => sound; set => sound = value; }

        internal Flyable FlyCapability { get => flyCapability; set => flyCapability = value; }

        public String trytofly() //not ok, not everybody is flying
        {
            return FlyCapability.fly();
        }
    }
}
