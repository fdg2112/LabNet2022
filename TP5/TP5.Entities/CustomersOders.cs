namespace TP5.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CustomersOrders
    {

        public string CustomerID { get; set; }

        public string CompanyName { get; set; }

        public string ContactName { get; set; }

        public int OrderID { get; set; }

        public int Quantity { get; set; }

        public DateTime? OrderDate { get; set; }

    }
}
