using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Entities;

namespace TP5.Data
{
    public static class ProductsData
    {
        public static IQueryable<Products> GetStockZero()
        {
            var db = new NorthwindContext();
            return from product in db.Products
                   where product.UnitsInStock == 0
                   select product;
        }

        public static IQueryable<Products> GetUnitPriceGreaterThan30()
        {
            var db = new NorthwindContext();
            return db.Products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 30)
                                .OrderBy(c => c.ProductName);
        }

        public static IQueryable<Products> GetFirstWithId789()
        {
            var db = new NorthwindContext();
            return db.Products.Where(p => p.ProductID == 789);
        }

        public static IQueryable<Products> GetProductsByName()
        {
            var db = new NorthwindContext();
            return from product in db.Products
                   orderby product.ProductName ascending
                   select product;
        }

        public static IQueryable<Products> GetProductsPerUnitInStock()
        {
            var db = new NorthwindContext();
            return db.Products.Where(p => p.UnitsInStock > 0)
                                .OrderByDescending(c => c.UnitsInStock);
        }

    }
}
