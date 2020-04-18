using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
           // ArrayListMethod();
           List<string> names=new List<string>();
           names.Add("ahmet");
           names.Add("mehmet");

           foreach (var name in names)
           {
               Console.WriteLine(name);
           }

           List<Customer> customers = new List<Customer>
           {
               new Customer(){Id = 1,Name = "Personel1"},
               new Customer(){Id = 2,Name = "Personel2"}
           };

           foreach (var customer in customers)
           {
               Console.WriteLine(customer.Name);
           }

            Console.ReadLine();
        }

        private static void ArrayListMethod()
        {
            ArrayList cities = new ArrayList();
            cities.Add("ankara");
            cities.Add("dbakir");
            cities.Add("istanb");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

           
        }

        class  Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }  
        }
    }
}
