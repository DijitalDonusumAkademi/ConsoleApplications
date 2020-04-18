using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Abstract;

namespace Interfaces.Concrete
{
    public class OracleCustomerDal:ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("OracleCustomerDal Add");
        }

        public void Delete()
        {
            Console.WriteLine("OracleCustomerDal Delete");
        }

        public void Update()
        {
            Console.WriteLine("OracleCustomerDal Update");
        }
    }
}
