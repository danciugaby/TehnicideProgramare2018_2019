using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    class ToyHouse : IToy
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
        
     
    }
}
