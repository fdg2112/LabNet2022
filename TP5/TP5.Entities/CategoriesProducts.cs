namespace TP5.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CategoriesProducts
    {
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }


    }
}
