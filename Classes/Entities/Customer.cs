using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Entities
{
    public class Customer
    {
        private string _name;
        public int Id { get; set; }

        public string Name
        {
            get => _name;
            set { _name = value; }
        }

        public string SurName { get; set; }
        public string City { get; set; }
    }
}
