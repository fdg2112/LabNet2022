using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Entities;

namespace TP5.Data
{
    public static class ProductsLogic
    {
        public static List<Products> GetStockZero()
        {
            var db = new NorthwindContext();
            return (from product in db.Products
                   where product.UnitsInStock == 0
                   select product).ToList();
        }

        public static List<Products> GetUnitPriceGreaterThan3()
        {
            var db = new NorthwindContext();
            return db.Products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3)
                                .OrderBy(c => c.ProductName).ToList();
        }

        public static List<Products> GetFirstWithId789()
        {
            var db = new NorthwindContext();
            return db.Products.Where(p => p.ProductID == 789).ToList();
        }

        public static List<Products> GetProductsByName()
        {
            var db = new NorthwindContext();
            return (from product in db.Products
                   orderby product.ProductName ascending
                   select product).ToList();
        }

        public static List<Products> GetProductsPerUnitInStock()
        {
            var db = new NorthwindContext();
            return db.Products.Where(p => p.UnitsInStock > 0)
                                .OrderByDescending(c => c.UnitsInStock).ToList();
        }

        public static List<Products> GetAll()
        {
            var db = new NorthwindContext();
            return (from product in db.Products
                    orderby product.ProductID ascending
                    select product).ToList();
        }
    }
}
