using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Entities;
using TP4.Logic;

namespace TP4
{
    public static class Modificaciones
    {
        public static void ModificarProveedor()
        {
            try
            {
                SuppliersLogic suppliersLogic = new SuppliersLogic();
                Console.WriteLine("Ingrese ID del Proveedor a modificar");
                int id = Convert.ToInt32(Console.ReadLine());
                if (suppliersLogic.Finded(id))
                {
                    Console.WriteLine("Modificar nombre de contacto de la empresa");
                    string contactName = Console.ReadLine();
                    if (contactName.Length > 30)
                    {
                        throw new Exception("Se ha sobrepasado el limite de 30 caracteres en el campo Nombre de Contacto");
                    }
                    Console.WriteLine("Ingrese nuevo telefono");
                    string phone = Console.ReadLine();
                    if (phone.Length > 24)
                    {
                        throw new Exception("Se ha sobrepasado el limite de 24 caracteres en el campo Telefono");
                    }
                    suppliersLogic.Update(new Suppliers
                    {
                        SupplierID = id,
                        ContactName = contactName,
                        Phone = phone
                    });
                }
                else Console.WriteLine("ID no encontrado");  
            }
            catch (Exception ex)
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Ha ocurrido el siguiente error:");
                Console.WriteLine(ex.Message);
                Console.WriteLine("No se guardaran los cambios...");
            }  
        }

        public static void ModificarTransportista()
        {
            try
            {
                ShippersLogic shippersLogic = new ShippersLogic();
                Console.WriteLine("Ingrese ID del Transporista a modificar");
                int id = Convert.ToInt32(Console.ReadLine());
                if (shippersLogic.Finded(id))
                {
                    Console.WriteLine("Ingrese nuevo telefono");
                    string phone = Console.ReadLine();
                    if (phone.Length > 24)
                    {
                        throw new Exception("Se ha sobrepasado el limite de 24 caracteres en el campo Telefono");
                    }
                    shippersLogic.Update(new Shippers
                    {
                        ShipperID = id,
                        Phone = phone
                    });
                }
                else Console.WriteLine("ID no encontrado");
            }
            catch (Exception ex)
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Ha ocurrido el siguiente error:");
                Console.WriteLine(ex.Message);
                Console.WriteLine("No se guardaran los cambios...");
            }
        }
    }
}
