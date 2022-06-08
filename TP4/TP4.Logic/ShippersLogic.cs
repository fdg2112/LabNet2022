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
            context.Shippers.Add(newElement);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var elementToRemove = context.Shippers.Find(id);
            context.Shippers.Remove(elementToRemove);
            context.SaveChanges();
        }

        public void Update(Shippers element)
        {
            var shippersUpdate = context.Shippers.Find(element.ShipperID);
            shippersUpdate.Phone = element.Phone;
            context.SaveChanges();
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
