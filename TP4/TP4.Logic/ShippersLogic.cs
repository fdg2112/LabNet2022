using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Entities;

namespace TP4.Logic
{
    public class ShippersLogic : BaseLogic, IABMLogic<Shippers>
    {
        public void Add(Shippers newElement)
        {
            try
            {
                if (string.IsNullOrEmpty(newElement.CompanyName)) throw new Exception("El campo Nombre de la empresa no puede estar vacio");
                context.Shippers.Add(newElement);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("No se ha podido agregar");
            }
            
        }

        public void Delete(int id)
        {
            try
            {
                var elementToRemove = context.Shippers.Find(id);
                context.Shippers.Remove(elementToRemove);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("No se ha podido eliminar");
            }
        }

        public void Update(Shippers element)
        {
            try
            {
                var shippersUpdate = context.Shippers.Find(element.ShipperID);
                if (element.CompanyName != null)
                {
                    if (element.CompanyName.Length > 60) throw new Exception("Se ha sobrepasado el límite de caracteres permitidos");
                    else shippersUpdate.CompanyName = element.CompanyName;
                }
                if (element.Phone != null)
                {
                    if (element.Phone.Length > 24) throw new Exception("Se ha sobrepasado el límite de caracteres permitidos");
                    else shippersUpdate.Phone = element.Phone;
                }
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("No se ha podido modificar");
            }
        }

        public bool Finded(int id)
        {
            if (context.Shippers.Find(id) != null) return true;
            else return false;
        }

        public List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }
    }
}
