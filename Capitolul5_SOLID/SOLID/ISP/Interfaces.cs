using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    interface IToy
    {
        void setPrice(double price);
        void setColor(String color);
       // void move();
      //  void fly();
    }

    interface IMovable
    {
        void move();
    }
    interface IFlyable
    {
        void fly();
    }
}
