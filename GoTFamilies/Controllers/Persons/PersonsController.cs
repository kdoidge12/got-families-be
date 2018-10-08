using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GoTFamilies.Managers;
using GoTFamilies.Models.Data.Contracts.Persons;
using GoTFamilies.Models.Data.Persons;
using GoTFamilies.Models.Domain.Persons;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace GoTFamilies.Controllers
{
    [Route("/Persons")]
    [EnableCors("AllowSpecificOrigin")]
    public class PersonsController : BaseController<Person>
    {
        private PersonManager perMgr;
        public PersonsController(BaseManager<Person> mgr) :base(mgr)
        {
            perMgr = mgr as PersonManager;
        }

        [Route("/Person/{name}")]
        [HttpGet]
        public Person GetPerson(string name)
        {
            Person get = perMgr.FindPerson(name);
            return get;
        }
        [Route("/newPerson")]
        [HttpPost]
        public void Post(PersonDTO person)
        {
            Person _person = new Person(person);
            perMgr.Insert(_person);
            
        }

        [Route("/Person/all")]
        [HttpGet]
        public List<Person> ReturnAll()
        {
            return perMgr.FindAll();
        }
    }
}