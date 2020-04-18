using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Abstract;

namespace Interfaces.Concrete
{
    public class SqlCustomerDal:ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQL Add");
        }

        public void Delete()
        {
            Console.WriteLine("SQL Delete");
        }

        public void Update()
        {
            Console.WriteLine("SQL Update");
        }
    }
}
