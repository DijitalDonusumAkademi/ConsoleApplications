using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFrameworkWin.Entities;

namespace EFrameworkWin.Context
{
    public class ETradeContext:DbContext
    {
        public ETradeContext()
        {
            
        }
        public DbSet<Product> Products { get; set; }
    }
}
