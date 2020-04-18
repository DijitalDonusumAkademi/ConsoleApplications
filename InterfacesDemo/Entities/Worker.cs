using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDemo.Abstract;

namespace InterfacesDemo.Entities
{
    public class Worker:IWorker,ISalary
    {
        public void Work()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }
    }
}
