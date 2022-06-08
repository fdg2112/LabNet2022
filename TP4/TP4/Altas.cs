using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Logic;
using TP4.Entities;

namespace TP4
{
    public static class Altas
    {
        public static void AgregarProveedor()
        {
            SuppliersLogic suppliers = new SuppliersLogic();
            Console.WriteLine("Nombre de la empresa");
            string companyName = Console.ReadLine();
            Console.WriteLine("Nombre del contacto de la empresa");
            string contactName = Console.ReadLine();
            Console.WriteLine("Titulo del contacto");
            string contactTitle = Console.ReadLine();
            Console.WriteLine("Direccion");
            string address = Console.ReadLine();
            Console.WriteLine("Ciudad");
            string city = Console.ReadLine();
            Console.WriteLine("Region");
            string region = Console.ReadLine();
            Console.WriteLine("Codigo Postal");
            string postalCode = Console.ReadLine();
            Console.WriteLine("Pais");
            string country = Console.ReadLine();
            Console.WriteLine("Telefono");
            string phone = Console.ReadLine();
            Console.WriteLine("Fax");
            string fax = Console.ReadLine();
            Console.WriteLine("Pagina Web");
            string homePage = Console.ReadLine();
            suppliers.Add(new Suppliers
            {
                CompanyName =  companyName,
                ContactName = contactName,
                ContactTitle = contactTitle,
                Address = address,
                City = city,
                Region = region,
                PostalCode = postalCode,
                Country = country,
                Phone = phone,
                Fax = fax,
                HomePage = homePage
            });
        }

        public static void AgregarTransportista()
        {
            ShippersLogic shipper = new ShippersLogic();
            Console.WriteLine("Nombre de la empresa");
            string companyName = Console.ReadLine();
            Console.WriteLine("Telefono de la empresa");
            string phone = Console.ReadLine();
            shipper.Add(new Shippers
            {
                CompanyName = companyName,
                Phone = phone,
            });
        }
    }
}
