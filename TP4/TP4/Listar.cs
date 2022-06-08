using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Logic;

namespace TP4
{
    public static class Listar
    {
        public static void MostrarProveedores()
        {
            SuppliersLogic suppliers = new SuppliersLogic();
            foreach (var item in suppliers.GetAll())
            {
                Console.WriteLine($"ID: {item.SupplierID} - {item.CompanyName} - Telefono: {item.Phone}");
            }
        }

        public static void MostrarTransportistas()
        {
            ShippersLogic shippers = new ShippersLogic();
            foreach (var item in shippers.GetAll())
            {
                Console.WriteLine($"ID: {item.ShipperID} - {item.CompanyName} - Telefono: {item.Phone}");
            }
        }
    }
}
