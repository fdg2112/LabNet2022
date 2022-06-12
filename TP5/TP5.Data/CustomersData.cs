using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Entities;

namespace TP5.Data
{
    public static class CustomersData
    {
        public static IQueryable<Customers> GetAll()
        { 
            var db = new NorthwindContext();
            return from customer in db.Customers
                        orderby customer.CompanyName ascending
                        select customer;
        }

        public static IQueryable<Customers> GetFromWA()
        {
            var db = new NorthwindContext();
            return db.Customers.Where(c => c.Region == "WA");
        }

        public static IQueryable<Customers> GetNames()
        {
            var db = new NorthwindContext();
            return db.Customers.OrderBy(c => c.ContactName);
        }

        public static void GetFromWaAnd1997()
        {
            var db = new NorthwindContext();

            
            var query = from customer in db.Customers
                        join order in db.Orders
                        on new { customer.CustomerID }
                        equals new { order.CustomerID }
                        where customer.Region == "WA" && order.OrderDate > new DateTime(1997,1,1)
                        select new {
                            customer.CompanyName,
                            customer.ContactName,
                            order.CustomerID,
                            order.OrderID,
                            order.OrderDate
                        };

            foreach (var item in query)
            {
                Console.WriteLine($"Customer: {item.CompanyName} - OrderID: {item.OrderID} - OrderDate: {item.OrderDate}");
            }
        }

        public static IQueryable<Customers> GetFromWaTop3()
        {
            var db = new NorthwindContext();
            return db.Customers.Where(c => c.Region == "WA").Take(3);
        }
    }
}
