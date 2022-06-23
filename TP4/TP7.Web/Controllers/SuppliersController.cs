using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP4.Entities;
using TP4.Logic;
using TP7.Web.Models;

namespace TP7.Web.Controllers
{
    public class SuppliersController : Controller
    {
        SuppliersLogic suppliersLogic = new SuppliersLogic();
        // GET: Suppliers
        public ActionResult Index()
        {
            List<Suppliers> suppliers = suppliersLogic.GetAll();

            List<SuppliersView> suppliersView = suppliers.Select(s => new SuppliersView
            {
                SupplierID = s.SupplierID,
                CompanyName = s.CompanyName,
                ContactName = s.ContactName,
                ContactTitle = s.ContactTitle,
                Address = s.Address,
                City = s.City,
                Region = s.Region,
                PostalCode = s.PostalCode,
                Country = s.Country,
                HomePage = s.HomePage,
                Phone = s.Phone,
                Fax = s.Fax
            }).ToList();

            return View(suppliersView);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(SuppliersView suppliersView)
        {
            try
            {
                Suppliers supplierEntity = new Suppliers
                {
                    CompanyName = suppliersView.CompanyName,
                    ContactName = suppliersView.ContactName,
                    ContactTitle= suppliersView.ContactTitle,
                    Address = suppliersView.Address,
                    City= suppliersView.City,
                    PostalCode= suppliersView.PostalCode,
                    Region = suppliersView.Region,
                    Country = suppliersView.Country,
                    Phone = suppliersView.Phone,
                    HomePage = suppliersView.HomePage,
                    Fax = suppliersView.Fax
                };
                if (!ModelState.IsValid) return RedirectToAction("Insert");
                suppliersLogic.Add(supplierEntity);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                suppliersLogic.Delete(id);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, SuppliersView suppliersView)
        {
            try
            {
                Suppliers supplierEntity = new Suppliers
                {
                    SupplierID = id,
                    CompanyName = suppliersView.CompanyName,    
                    ContactName = suppliersView.ContactName,
                    ContactTitle = suppliersView.ContactTitle,
                    Address = suppliersView.Address,
                    City = suppliersView.City,
                    Region = suppliersView.Region,
                    PostalCode = suppliersView.PostalCode,
                    Country = suppliersView.Country,
                    Fax = suppliersView.Fax,
                    HomePage = suppliersView.HomePage,
                    Phone = suppliersView.Phone
                };
                suppliersLogic.Update(supplierEntity);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }
    }
}