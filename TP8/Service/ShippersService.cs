using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Entities;
using TP4.Logic;

namespace Service
{
    public class ShippersService 
    {
               
        ShippersLogic shippersLogic = new ShippersLogic();

        public List<Shippers> GetAllShippers()
        {
            try
            {
                return shippersLogic.GetAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void AddShipper(Shippers shipper)
        {
            try
            {
                shippersLogic.Add(shipper);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeleteShipper(int id)
        {
            try
            {
                shippersLogic.Delete(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void EditShipper(Shippers shipper)
        {
            try
            {
                shippersLogic.Update(shipper);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
