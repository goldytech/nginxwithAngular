using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
namespace customer_api.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        // GET api/customer
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Customer-1", "Customer-2" };
        }
    }
}