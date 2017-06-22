using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace orders_api.Controllers
{
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {
        // GET api/orders
        [HttpGet]
        public IEnumerable<string> Get()
        {

            return new string[] { "order-1", "order-2" };
        }
    }
}