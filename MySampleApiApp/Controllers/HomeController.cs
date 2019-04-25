using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MySampleApiApp.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetResult([FromUri] string id)
        {
            return Ok(new { Id = 2, Name = "Test" });
        }

        [HttpPost]
        public IHttpActionResult SaveResult(string name)
        {
            return Ok(new { Id = 4, Name = "saved "+name });
        }
    }
}
