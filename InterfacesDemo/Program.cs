using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDemo.Abstract;
using InterfacesDemo.Entities;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker [] workers=new IWorker[3]
            {
                new Worker(), new Manager(), new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }
        }
    }
}
