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
using System.Web.Http.Cors;

namespace WebApi.Controllers
{
    [EnableCors(origins: "http://localhost:4200/", headers: "*", methods: "*")]
    public class SuppliersController : ApiController
    {

        SuppliersService suppliersService = new SuppliersService();

        // GET: api/Shippers
        public IHttpActionResult GetShippers()
        {
            try
            {
                var supplierList = suppliersService.GetAllSuppliers().Select(s => new SuppliersResponse
                {
                    SupplierID = s.SupplierID,
                    CompanyName = s.CompanyName,
                    ContactTitle = s.ContactTitle,
                    Address = s.Address,
                    City = s.City,
                    Region = s.Region,
                    PostalCode = s.PostalCode,
                    Country = s.Country,
                    Fax = s.Fax,
                    HomePage = s.HomePage,
                    Phone = s.Phone
                }).ToList();

                return Ok(supplierList);
            }
            catch (Exception e)
            {
                return Content(HttpStatusCode.NotFound, e.Message);
            }
        }

        // POST: api/Shippers
        public IHttpActionResult InsertSupplier([FromBody] SuppliersRequest suppliersRequest)
        {
            try
            {
                var supplier = new Suppliers
                {
                    CompanyName = suppliersRequest.CompanyName,
                    Phone = suppliersRequest.Phone
                };
                suppliersService.AddSupplier(supplier);
                return Content(HttpStatusCode.Created, supplier);
            }
            catch (Exception e)
            {
                return Content(HttpStatusCode.BadRequest, e.Message);
            }
        }

        // PUT: api/Shippers/{id}
        public IHttpActionResult EditSupplier(int id, [FromBody] SuppliersRequest suppliersRequest)
        {
            try
            {
                Suppliers supplier = new Suppliers
                {
                    SupplierID = id,
                    CompanyName = suppliersRequest.CompanyName,
                    ContactTitle = suppliersRequest.ContactTitle,
                    Address = suppliersRequest.Address,
                    City = suppliersRequest.City,
                    PostalCode = suppliersRequest.PostalCode,
                    Region = suppliersRequest.Region,
                    Country = suppliersRequest.Country,
                    Fax = suppliersRequest.Fax,
                    HomePage = suppliersRequest.HomePage,
                    Phone = suppliersRequest.Phone
                };
                suppliersService.EditSupplier(supplier);
                return Content(HttpStatusCode.OK, supplier);
            }
            catch (Exception e)
            {
                return Content(HttpStatusCode.BadRequest, e.Message);
            }
        }

        // DELETE: api/Shippers/{id}
        public IHttpActionResult DeleteSupplier(int id)
        {
            try
            {
                suppliersService.DeleteSupplier(id);
                return Content(HttpStatusCode.OK,"Eliminado");
            }
            catch (Exception e)
            {
                return Content(HttpStatusCode.BadRequest, e.Message);
            }
        }
    }
}
