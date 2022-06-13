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
        public static List<Customers> GetAll()
        { 
            var db = new NorthwindContext();
            return (from customer in db.Customers
                        orderby customer.CompanyName ascending
                        select customer).ToList();
        }

        public static List<Customers> GetFromWA()
        {
            var db = new NorthwindContext();
            return db.Customers.Where(c => c.Region == "WA").ToList();
        }

        public static List<Customers> GetNames()
        {
            var db = new NorthwindContext();
            return db.Customers.OrderBy(c => c.ContactName).ToList();
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

            //No he logrado todavía retornar la query
            foreach (var item in query)
            {
                Console.WriteLine($"Customer: {item.CompanyName} - OrderID: {item.OrderID} - OrderDate: {item.OrderDate}");
            }
        }

        public static List<Customers> GetFromWaTop3()
        {
            var db = new NorthwindContext();
            return db.Customers.Where(c => c.Region == "WA").Take(3).ToList();
        }
    }
}
