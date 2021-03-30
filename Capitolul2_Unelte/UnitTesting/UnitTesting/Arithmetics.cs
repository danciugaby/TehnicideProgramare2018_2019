using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class Arithmetics
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public double Sum(double a, double b)
        {
            return a + b;
        }
        public double Multiply(double a, double b)
        {
            
            return a*b;
        }

        public int Sum(int[] a)
        {
            int s = 0;
            foreach (int i in a)
                s += i;
            return s;
        }
    }
}
