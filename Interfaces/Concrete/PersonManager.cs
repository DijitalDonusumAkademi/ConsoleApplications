using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Abstract;
using Interfaces.Entities;

namespace Interfaces.Concrete
{
    public class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName+"  eklendi");
        }
    }
}
