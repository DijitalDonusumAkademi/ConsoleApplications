using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics.Entities.Abstract;

namespace Generics.Abstract
{
    public interface IRepository<T> where T:class, IEntity, new()
    {
        List<T> GetList();
        T Get(int id);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}
