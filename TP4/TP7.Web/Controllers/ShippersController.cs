using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP4.Logic;
using TP4.Entities;
using TP7.Web.Models;

namespace TP7.Web.Controllers
{
    public class ShippersController : Controller
    {
        // GET: Shippers
        ShippersLogic shippersLogic = new ShippersLogic();

        public ActionResult Index()
        {
            List<Shippers> shippers = shippersLogic.GetAll();

            List<ShippersView> shippersView = shippers.Select(s => new ShippersView
            {
                ShipperID = s.ShipperID,
                CompanyName = s.CompanyName,
                Phone = s.Phone
            }).ToList();

            return View(shippersView);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(ShippersView shippersView)
        {
            try
            {
                Shippers shipperEntity = new Shippers
                {
                    CompanyName = shippersView.CompanyName,
                    Phone = shippersView.Phone
                };
                if (!ModelState.IsValid) return RedirectToAction("Insert");
                shippersLogic.Add(shipperEntity);
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
                shippersLogic.Delete(id);
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
        public ActionResult Edit(int id, ShippersView shippersView)
        {
            try
            {
                Shippers shipperEntity = new Shippers
                {
                    ShipperID = id,
                    CompanyName = shippersView.CompanyName,
                    Phone = shippersView.Phone
                };
                shippersLogic.Update(shipperEntity);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }
    }
}