using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    class A
    {
        int stupidsample = 1;
    }
    class Program
    {
        static void Main(string[] args)
        {

           //double areas = Area(new object[] { new Rectangle(1, 2), new Circle(2), new A() }); //model gresit!
           double areas = AreaCalculator.Area( new Shape[] { new Rectangle(1, 2), new Circle(2)});
        }

        public static  double Area(object[] shapes) //gresit pentru ca pot primi orice
        {
            double area = 0;
            foreach (var shape in shapes) //daca obiectul transmis nu e niciuna de mai jos?
            {
                if (shape is Rectangle)
                {
                    Rectangle rectangle = (Rectangle)shape;
                    area += rectangle.Width * rectangle.Height;
                }
                else
                {
                    Circle circle = (Circle)shape;
                    area += circle.Radius * circle.Radius * Math.PI;
                }
            }

            return area;
        }
    }
}
