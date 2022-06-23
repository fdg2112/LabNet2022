using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TP7.Web.Models
{
    public class SuppliersView
    {
        [Display(Name = "ID")]
        public int SupplierID { get; set; }

        [Display(Name = "Nombre de la empresa")]
        [Required]
        [StringLength(40)]
        public string CompanyName { get; set; }

        [Display(Name = "Nombre del contacto")]
        [StringLength(30)]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "Solo letras en este campo")]
        public string ContactName { get; set; }

        [Display(Name = "Titulo del contacto")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "Solo letras en este campo")]
        [StringLength(30)]
        public string ContactTitle { get; set; }

        [Display(Name = "Direccion")]
        [StringLength(60)]
        public string Address { get; set; }

        [Display(Name = "Ciudad")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "Solo letras en este campo")]
        [StringLength(15)]
        public string City { get; set; }

        [Display(Name = "Region")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "Solo letras en este campo")]
        [StringLength(15)]
        public string Region { get; set; }

        [Display(Name = "Codigo Postal")]
        [StringLength(10)]
        public string PostalCode { get; set; }
 
        [Display(Name = "Pais")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "Solo letras en este campo")]
        [StringLength(15)]
        public string Country { get; set; }

        [Display(Name = "Telefono")]
        [StringLength(24)]
        [RegularExpression("^[1-9]+$", ErrorMessage = "Solo numeros en este campo")]
        public string Phone { get; set; }

        [Display(Name = "Fax")]
        [StringLength(24)]
        public string Fax { get; set; }

        [Display(Name = "Pagina Web")]
        [Url]
        public string HomePage { get; set; }
    }
}