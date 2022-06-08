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
            context.Suppliers.Add(newElement);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var elementToRemove = context.Suppliers.Find(id);
            context.Suppliers.Remove(elementToRemove);
            context.SaveChanges();
        }

        public void Update(Suppliers element)
        {
            var supliersUpdate = context.Suppliers.Find(element.SupplierID);
            supliersUpdate.ContactName = element.ContactName;
            supliersUpdate.Phone = element.Phone;
            context.SaveChanges();
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
