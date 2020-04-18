using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Inheritances.Models;

namespace Inheritances
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Student{Name = "Mehmet Öğrenci",Id = 1,Departman = "Bilişim",Surname = "Emin"},
                new Customer{Id = 2,Name = "Cutome Emrah",Surname = "Kalel",City = "Ankara"},
                new Person{Id = 3,Name ="Eran Person",Surname = "Ola"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine("ID : " + person.Id + " Name : " + person.Name + " Surname: " + person.Surname);

            }

            Console.ReadLine();
        }
    }
}
