using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DelegateDemo.Delegate;

namespace DelegateDemo
{
    class FunctionContainer
    {
        public static int computeAggregateValue(int[] values, AggregateMethod method)
        {
            int currentValue = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                currentValue = method(currentValue, values[i]);
            }
            return currentValue;
        }

        public static int min(int a, int b)
        {
            return a < b ? a : b;
        }

        public static int sum(int a, int b)
        {
            return a + b;
        }
        public static int diff(int a, int b)
        {
            return a - b;
        }
    }
}
