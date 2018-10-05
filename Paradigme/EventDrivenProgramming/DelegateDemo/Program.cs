using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DelegateDemo.Delegate;

namespace DelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int resultSum = computeAggregateValue(numbers, sum);
            Console.WriteLine("Result for sum: {0}", resultSum.ToString());
            int resultMin = computeAggregateValue(numbers, min);
            Console.WriteLine("Result for min: {0}", resultMin.ToString());

        }
        private static int computeAggregateValue(int[] values, AggMEthod method)
        {
            int currentValue = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                currentValue = method(currentValue, values[i]);
            }
            return currentValue;
        }

        private static int min(int a, int b)
        {
            return a < b ? a : b;
        }

        private static int sum(int a, int b)
        {
            return a + b;
        }

    }
}
