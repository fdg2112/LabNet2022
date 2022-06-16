using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP4.Logic;
using TP4.Entities;

namespace TP7.Web.Controllers
{
    public class ShippersController : Controller
    {
        // GET: Shippers
        public ActionResult Index()
        {
            var shippersLogic = new ShippersLogic();

            List<Shippers> shippers = shippersLogic.GetAll();

            return View(shippers);
        }
    }
}