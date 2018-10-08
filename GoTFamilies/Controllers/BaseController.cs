using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using GoTFamilies.Models.Data;
using GoTFamilies.Managers;

namespace GoTFamilies.Controllers
{
    [EnableCors("AllowSpecificOrigin")]
    public abstract class BaseController<TType> : Controller 
        where TType:IBaseEntity
    {
        private readonly BaseManager<TType> mgr;

        public BaseController(BaseManager<TType> mgr)
        {
            this.mgr = mgr;
        }

    }
}