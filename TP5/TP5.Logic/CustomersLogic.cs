using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Entities;

namespace TP5.Data
{
    public static class CustomersLogic
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

        public static List<CustomersOrders> GetFromWaAnd1997()
        {
            var db = new NorthwindContext();

            
            return (from c in db.Customers
                        join o in db.Orders
                        on c.CustomerID
                        equals o.CustomerID
                        where c.Region == "WA" && o.OrderDate > new DateTime(1997,1,1)
                        select new CustomersOrders
                        {                       
                            CustomerID = c.CustomerID,
                            CompanyName = c.CompanyName,
                            ContactName = c.ContactName,
                            OrderID = o.OrderID,
                            OrderDate = o.OrderDate
                        }).ToList();
        }

        public static List<Customers> GetFromWaTop3()
        {
            var db = new NorthwindContext();
            return db.Customers.Where(c => c.Region == "WA").Take(3).ToList();
        }
    }
}
