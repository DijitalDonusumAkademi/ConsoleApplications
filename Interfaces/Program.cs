using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Abstract;
using Interfaces.Concrete;
using Interfaces.Entities;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
           // PersonManager manager=new PersonManager();

//            interfaceIntro(manager);

            //CustomerManager customerManager=new CustomerManager();
            //customerManager.Add(new SqlCustomerDal());

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlCustomerDal(), new OracleCustomerDal()

            };

            foreach (var dal in customerDals)
            {
                dal.Add();
            }

            Console.ReadLine();
        }

        private static void interfaceIntro(PersonManager manager)
        {
            Customer customer = new Customer
            {
                FirstName = "Customer Emin",
                LastName = "Gelen",
                Id = 1,
                Address = "adres1"
            };

            manager.Add(customer);

            Student student = new Student
            {
                FirstName = "Student Mustafa",
                LastName = "Gelen",
                Id = 1,
                Departmant = "Departmant"
            };

            manager.Add(student);

            Worker worker = new Worker
            {
                FirstName = "Worker Ali",
                LastName = "Gelen",
                Id = 1,
                DepartmanName = "Departmant Worker"
            };

            manager.Add(worker);
        }
    }

    


 
}
