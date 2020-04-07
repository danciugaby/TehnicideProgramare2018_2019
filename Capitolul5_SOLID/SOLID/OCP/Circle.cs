using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    class Circle :Shape
    {
        public Circle(int radius)
        {
            Radius = radius;
        }

        public int Radius { get; internal set; }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
