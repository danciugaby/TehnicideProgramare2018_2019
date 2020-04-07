using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    class ToyPlane : IToy, IMovable, IFlyable
    {
        double price;
        String color;
        public void setPrice(double price)
        {
            this.price = price;
        }
        public void setColor(String color)
        {
            this.color = color;
        }
        public void fly()
        {
            Console.WriteLine("fly");
        }

        public void move()
        {
            Console.WriteLine("move");
        }

    }
}
