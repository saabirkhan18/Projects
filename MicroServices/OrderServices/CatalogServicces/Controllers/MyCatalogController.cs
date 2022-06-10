using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyCatalogController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            string[] Summaries = new[] { "Catalog_1", "Catalog_2", "Catalog_3"};
            var rng = new Random();
            return Summaries.ToArray();
        }
    }
}
