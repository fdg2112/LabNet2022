using Poke_Api.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Poke_Api.Controllers
{
    public class PokeController : ApiController
    {
        PokeService pokeService = new PokeService();

        // GET: api/Poke
        public IHttpActionResult GetPokes()
        {
            try
            {
                var pokeList = pokeService.GetPokemones().Select(p => new PokeResponse
                {
                    
                }).ToList();

                return Ok(pokeList);
            }
            catch (Exception e)
            {
                return Content(HttpStatusCode.NotFound, e.Message);
            }
        }
    }
}
