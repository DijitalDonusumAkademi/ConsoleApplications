using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics.Abstract;
using Generics.Entities;

namespace Generics.Abstract
{
    public interface IProductDal:IRepository<Product>
    {
    }
}
