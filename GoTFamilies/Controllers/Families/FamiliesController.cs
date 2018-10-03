using System.Collections.Generic;
using GoTFamilies.Models.Data.Persons;
using GoTFamilies.Models.Domain.Persons;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver.Core.Operations;

namespace GoTFamilies.Controllers.Families
{
    [Route("/Families")]
    public class FamiliesController : BaseController
    {
        private PersonRepo repo;
        public FamiliesController()
        {
            repo = new PersonRepo();
        }
        [Route("/GetFamilyMembers/{string}")]
        [HttpGet]
        public List<Person> GetFamilyMembers(string name)
        {
            return repo.FindAllLastName(name);
        }
    }
}