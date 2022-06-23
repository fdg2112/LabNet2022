using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TP7.Web.Models
{
    public class ShippersView
    {
        [Display (Name="ID")]
        public int ShipperID { get; set; }

        [Display(Name = "Nombre de la empresa")]
        [Required]
        [StringLength(40)]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "Solo letras en este campo")]
        public string CompanyName { get; set; }

        [Display(Name = "Telefono")]
        [StringLength(24)]
        [RegularExpression("^[1-9]+$", ErrorMessage = "Solo numeros en este campo")]
        public string Phone { get; set; }
    }
}