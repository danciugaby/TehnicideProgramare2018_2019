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
            

            int resultSum = FunctionContainer.computeAggregateValue(numbers, FunctionContainer.sum);
            Console.WriteLine("Result for sum: {0}", resultSum.ToString());

            int resultMin =FunctionContainer.computeAggregateValue(numbers, FunctionContainer.min);
            Console.WriteLine("Result for min: {0}", resultMin.ToString());

            int resultDiff = FunctionContainer.computeAggregateValue(numbers, FunctionContainer.diff);
            
            Console.WriteLine("Result for diff: {0}", resultDiff.ToString());

            
        }
        

       

        

    }
}
