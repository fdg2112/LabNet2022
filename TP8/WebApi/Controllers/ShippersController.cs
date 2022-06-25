using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Entities;
using WebApi.Models.Request;
using WebApi.Models.Response;

namespace WebApi.Controllers
{
    public class ShippersController : ApiController
    {

        ShippersService shippersService = new ShippersService();

        // GET: api/Shippers
        public IHttpActionResult GetShippers()
        {
            try
            {
                var shippersList = shippersService.GetAllShippers().Select(s => new ShippersResponse
                {
                    ShipperID = s.ShipperID,
                    CompanyName = s.CompanyName,
                    Phone = s.Phone
                }).ToList();

                return Ok(shippersList);
            }
            catch (Exception e)
            {
                return Content(HttpStatusCode.NotFound, e.Message);
            }
        }

        // POST: api/Shippers
        public IHttpActionResult InsertShipper([FromBody] ShippersRequest shippersRequest)
        {
            try
            {
                var shipper = new Shippers
                {
                    CompanyName = shippersRequest.CompanyName,
                    Phone = shippersRequest.Phone
                };
                shippersService.AddShipper(shipper);
                return Content(HttpStatusCode.Created, shipper);
            }
            catch (Exception e)
            {
                return Content(HttpStatusCode.BadRequest, e.Message);
            }
        }

        // PUT: api/Shippers/{id}
        public IHttpActionResult EditShipper(int id, [FromBody] ShippersRequest shippersRequest)
        {
            try
            {
                Shippers shipper = new Shippers
                {
                    ShipperID = id,
                    CompanyName = shippersRequest.CompanyName,
                    Phone = shippersRequest.Phone
                };
                shippersService.EditShipper(shipper);
                return Content(HttpStatusCode.OK, shipper);
            }
            catch (Exception e)
            {
                return Content(HttpStatusCode.BadRequest, e.Message);
            }
        }

        // DELETE: api/Shippers/{id}
        public IHttpActionResult DeleteShipper(int id)
        {
            try
            {
                shippersService.DeleteShipper(id);
                return Content(HttpStatusCode.OK,"Eliminado");
            }
            catch (Exception e)
            {
                return Content(HttpStatusCode.BadRequest, e.Message);
            }
        }
    }
}
