using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProj
{
    class Customer
    {
        public int Custid { get; set; }
        public string Name { get; set; }
        public String City { get; set; }
        public double bal { get; set; }

    }
    class TestCustomer
    {
        static void Main(string[] args)
        {
            List<Customer> c = new List<Customer>();
            Customer c1 = new Customer { Custid = 101, Name = "Lokesh", City = "blore", bal = 25000.34 };
            Customer c2 = new Customer { Custid = 102, Name = "will", City = "newyork", bal = 2323.242 };
            Customer c3 = new Customer { Custid = 103, Name = "mike", City = "spain", bal = 3423534.45 };
            Customer c4 = new Customer { Custid = 014, Name = "smith", City = "sydney", bal = 24354.345 };
            c.Add(c1);
            c.Add(c2);
            c.Add(c3);
            c.Add(c4);

            foreach (Customer obj in c)
            {
                Console.WriteLine(obj.Custid + " " + obj.Name + " " + obj.City + " " + obj.bal);
            }


        }
    }
}
