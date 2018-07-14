using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace GoTFamilies.Controllers
{
    public class BaseController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {"person controller1", "person controller2"};
        }
    }
}