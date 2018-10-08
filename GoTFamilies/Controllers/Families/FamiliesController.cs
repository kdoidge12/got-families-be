using System.Collections.Generic;
using GoTFamilies.Managers;
using GoTFamilies.Models.Data.Families;
using GoTFamilies.Models.Data.Persons;
using GoTFamilies.Models.Domain.Persons;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver.Core.Operations;

namespace GoTFamilies.Controllers.Families
{
    [Route("/Families")]
    public class FamiliesController : BaseController<Family>
    {
        private FamilyManager famMgr;
        public FamiliesController(BaseManager<Family> mgr):base(mgr)
        {
            famMgr = mgr as FamilyManager;
        }
        [Route("/GetFamilyMembers/{string}")]
        [HttpGet]
        public List<Person> GetFamilyMembers(string name)
        {
            return null;
        }
    }
}