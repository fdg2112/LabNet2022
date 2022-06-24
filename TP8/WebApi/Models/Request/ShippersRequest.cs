using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models.Request
{
    public class ShippersRequest
    {
        public string CompanyName { get; set; }

        public string Phone { get; set; }
    }
}