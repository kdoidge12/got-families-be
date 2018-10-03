using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace GoTFamilies.Controllers
{
    [EnableCors("AllowSpecificOrigin")]
    public class BaseController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {"person controller1", "person controller2"};
        }
    }
}