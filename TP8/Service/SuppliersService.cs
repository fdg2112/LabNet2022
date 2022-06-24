using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Entities;
using TP4.Logic;

namespace Service
{
    public class SuppliersService
    {
               
        SuppliersLogic suppliersLogic = new SuppliersLogic();

        public List<Suppliers> GetAllSuppliers()
        {
            try
            {
                return suppliersLogic.GetAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void AddSupplier(Suppliers supplier)
        {
            try
            {
                suppliersLogic.Add(supplier);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeleteSupplier(int id)
        {
            try
            {
                suppliersLogic.Delete(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void EditSupplier(Suppliers supplier)
        {
            try
            {
                suppliersLogic.Update(supplier);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
