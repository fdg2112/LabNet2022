using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Logic
{
    public class SuppliersLogic : BaseLogic, IABMLogic<Suppliers>
    {
        public void Add(Suppliers newElement)
        {
            try
            {
                if (string.IsNullOrEmpty(newElement.CompanyName)) throw new Exception("El campo Nombre de la empresa no puede estar vacio");
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
                if (element.CompanyName != null) supliersUpdate.CompanyName = element.CompanyName;
                if (element.ContactName != null) supliersUpdate.ContactName = element.ContactName;
                if (element.ContactTitle != null) supliersUpdate.ContactTitle = element.ContactTitle;
                if (element.Address != null) supliersUpdate.Address = element.Address;
                if (element.City != null) supliersUpdate.City = element.City;
                if (element.Region != null) supliersUpdate.Region = element.Region;
                if (element.PostalCode != null) supliersUpdate.PostalCode = element.PostalCode;
                if (element.Country != null) supliersUpdate.Country = element.Country;
                if (element.Phone != null) supliersUpdate.Phone = element.Phone;
                if (element.Fax != null) supliersUpdate.Fax = element.Fax;
                if (element.HomePage != null) supliersUpdate.HomePage = element.HomePage;
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
