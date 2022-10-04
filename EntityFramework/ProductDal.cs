﻿using AdoNetDemo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            // using: ETradeContext gibi nesnelere işi bittiğinde memory'de yer açar garbage collector'a gönderir.
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.ToList();
            }
        }

        public List<Product> GetByName(string key)
        {
            // using: ETradeContext gibi nesnelere işi bittiğinde memory'de yer açar garbage collector'a gönderir.
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.Name.Contains(key)).ToList();
            }
        }

        public List<Product> GetByUnitPrice(decimal price)
        {
            // using: ETradeContext gibi nesnelere işi bittiğinde memory'de yer açar garbage collector'a gönderir.
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice>=price).ToList();
            }
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            // using: ETradeContext gibi nesnelere işi bittiğinde memory'de yer açar garbage collector'a gönderir.
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice >= min && p.UnitPrice <= max).ToList();
            }
        }

        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                //context.Products.Add(product);
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
