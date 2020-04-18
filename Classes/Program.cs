using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Classes.Entities;
using Classes.Models;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager manager=new CustomerManager();
            manager.Add();
            manager.Delete();

            ProductManager productManager=new ProductManager();
            productManager.Add();
            productManager.Delete();
            productManager.Update();
            
            Customer customer=new Customer();
            customer.Id = 2;
            customer.City = "City";
            customer.Name = "Name 1";
            customer.SurName = "Surname";

            Customer customer2=new Customer
            {
                Id = 1,SurName = "Surname 2",City = "Ciy2",Name = "Name 1"
            };

            Console.WriteLine(customer2.Name);
            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine(" CustomerManager Add");
        }

        public void Delete()
        {
            Console.WriteLine(" CustomerManager Delete");
        }
    }
}
