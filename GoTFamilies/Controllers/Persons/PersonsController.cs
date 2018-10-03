using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GoTFamilies.Models.Data.Contracts.Persons;
using GoTFamilies.Models.Data.Persons;
using GoTFamilies.Models.Domain.Persons;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace GoTFamilies.Controllers
{
    [Route("/Persons")]
    [EnableCors("AllowSpecificOrigin")]
    public class PersonsController : BaseController
    {
        private PersonRepo repo;
        public PersonsController()
        {
            repo = new PersonRepo();
        }
        [Route("/Person/{name}")]
        [HttpGet]
        public Person GetPerson(string name)
        {
            Person get = repo.FindPerson(name);
            return get;
        }
        [Route("/newPerson")]
        [HttpPost]
        public void Post(PersonDTO person)
        {
            Person _person = new Person(person);
            repo.Insert(_person);
            
        }

        [Route("/Person/all")]
        [HttpGet]
        public List<Person> ReturnAll()
        {
            return repo.FindAll();
        }
    }
}