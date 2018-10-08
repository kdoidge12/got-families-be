using System;
using System.Collections.Generic;
using GoTFamilies.Models.Data.Persons;
using GoTFamilies.Models.Domain;
using GoTFamilies.Models.Domain.Persons;

namespace GoTFamilies.Managers
{
    public class PersonManager : BaseManager<Person>
    {
        private readonly PersonRepo perRepo;
        public PersonManager(BaseRepo<Person> repo) :base(repo)
        {
            perRepo = repo as PersonRepo;
        }

        public Person FindPerson(string name)
        {
            return perRepo.FindPerson(name);
        }

        public List<Person> FindAll()
        {
            return perRepo.FindAll();
        }

        public List<Person> FindByLastName(string name)
        {
            return perRepo.FindAllLastName(name);
        }

    }
}
