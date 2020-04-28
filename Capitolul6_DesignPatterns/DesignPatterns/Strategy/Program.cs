using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[] {
                new Dog(),
                new Bat(),
                new Bird()            
            };
            foreach (Animal a in animals)
            {
                Console.WriteLine(a.GetType());
                Console.WriteLine(a.trytofly());
            }
        }
    }
}
