using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Logic;

namespace TP4
{
    public static class Bajas
    {
        public static void BajaProveedor()
        {
            SuppliersLogic supplierLogic = new SuppliersLogic();
            Console.WriteLine("Ingrese ID del Proveedor a Eliminar");
            int id = Convert.ToInt32(Console.ReadLine());
            if (supplierLogic.Finded(id))
            {
                supplierLogic.Delete(id);
                Console.WriteLine("Eliminado...");
            }
            else Console.WriteLine("ID no encontrado");
        }

        public static void BajaTransportista()
        {
            ShippersLogic shippersLogic = new ShippersLogic();
            Console.WriteLine("Ingrese ID del Proveedor a Eliminar");
            int id = Convert.ToInt32(Console.ReadLine());
            if (shippersLogic.Finded(id))
            {
                shippersLogic.Delete(id);
                Console.WriteLine("Eliminado...");
            }
            else Console.WriteLine("ID no encontrado");
        }
    }
}
