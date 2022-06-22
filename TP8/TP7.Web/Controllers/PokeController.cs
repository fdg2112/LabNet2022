using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using TP7.Web.Models;

namespace TP7.Web.Controllers
{
    public class PokeController : Controller
    {
        PokeService pokeService = new PokeService();

        // GET: Poke
        public ActionResult Index()
        {
            try
            {
                List<PokesView> pokeView = pokeService.GetPokemones().Select(p => new PokesView
                {
                    Name = p.Name,
                    Url = p.Url
                }).ToList();

                return View(pokeView);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
