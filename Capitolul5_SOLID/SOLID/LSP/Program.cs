using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> Customers = new List<Customer>();
            Customers.Add(new SilverCustomer());
            Customers.Add(new GoldCustomer());
            //Customers.Add(new Enquiry()); //  nu mai pot sa fac asta

            foreach (Customer o in Customers)
            {
                o.Add(); //throw exception for Enquiry
            }
        }
    }
}
