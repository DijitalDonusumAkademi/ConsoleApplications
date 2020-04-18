using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFrameworkWin.Context;
using EFrameworkWin.Entities;

namespace EFrameworkWin.Dal
{
    public class ProductDal
    {
        public List<Product> GetProducts()
        {
            using (ETradeContext context = new ETradeContext())
            {

                return context.Products.ToList();
            }
        }
        public List<Product> GetByNameProducts(string key)
        {
            using (ETradeContext context = new ETradeContext())
            {

                return context.Products.Where(p => p.Name.ToLower().Contains(key)).ToList();
            }
        }
        public List<Product> GetByPriceBetween(decimal min,decimal max)
        {
            using (ETradeContext context = new ETradeContext())
            {

                return context.Products.Where(p => p.Price>=min&&p.Price<=max).ToList();
            }
        }

        public Product GetProductByName(string name)
        {
            using (ETradeContext context = new ETradeContext())
            {

                return context.Products.SingleOrDefault(p => p.Name==name);
            }
        }
        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
