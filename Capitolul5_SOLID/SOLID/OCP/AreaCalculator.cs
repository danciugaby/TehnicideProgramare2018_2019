using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class AreaCalculator
    {
       /* public double Area(Rectangle[] shapes) //fals pentru ca se leaga Area de Rectangle
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Width * shape.Height;
            }

            return area;
        }*/

        public static double Area(Shape[] shapes) //corect pentru ca va fi folosita de orice mosteneste Shape
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Area();
            }
            return area;
        }
    }
}
