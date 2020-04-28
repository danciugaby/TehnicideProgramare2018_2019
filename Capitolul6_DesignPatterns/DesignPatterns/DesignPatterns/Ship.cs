using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    abstract class  Ship
    {
        private String name;
        private double speed;

        public string Name { get => name; set => name = value; }
        public double Speed { get => speed; set => speed = value; }

        public override string ToString()
        {
            return "Ship " + name + " with speed " + speed;
        }
    }
}
