using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Entities;

namespace TP4.Logic
{
    public class SuppliersLogic : BaseLogic, IABMLogic<Suppliers>
    {
        public void Add(Suppliers newElement)
        {
            try
            {
                if (string.IsNullOrEmpty(newElement.CompanyName)) throw new Exception("El campo Nombre de la empresa no puede estar vacio");
                if (newElement.CompanyName.Length > 40 || newElement.ContactName.Length > 30 || newElement.ContactTitle.Length > 30 ||
                    newElement.Address.Length > 60 || newElement.City.Length > 15 || newElement.Region.Length > 15 ||
                    newElement.PostalCode.Length > 10 || newElement.Country.Length > 15 || newElement.Phone.Length > 24 || newElement.Fax.Length > 24)
                    throw new Exception("Uno o más campos han sobrepasado el límite de caracteres");
                context.Suppliers.Add(newElement);
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
                var elementToRemove = context.Suppliers.Find(id);
                context.Suppliers.Remove(elementToRemove);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("No se ha podido eliminar");
            }
        }

        public void Update(Suppliers element)
        {
            try
            {
                var supliersUpdate = context.Suppliers.Find(element.SupplierID);
                if (element.ContactName.Length > 30 || element.Phone.Length > 24) throw new Exception("Uno o más campos han sobrepasado el límite de caracteres ");
                supliersUpdate.ContactName = element.ContactName;
                supliersUpdate.Phone = element.Phone;
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("No se ha podido modificar");
            } 
        }

        public bool Finded(int id)
        {
            if (context.Suppliers.Find(id) != null) return true;
            else return false;
        }

        public List<Suppliers> GetAll()
        {
            return context.Suppliers.ToList();
        }
    }
}
