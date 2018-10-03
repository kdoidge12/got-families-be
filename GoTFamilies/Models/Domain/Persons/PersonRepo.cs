using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using GoTFamilies.Models.Data.Persons;
using MongoDB.Driver;

namespace GoTFamilies.Models.Domain.Persons
{
    public class PersonRepo : BaseRepo<Person>
    {
        public PersonRepo() : base("Persons")
        {
               
        }

        public Person FindPerson(string name)
        {
            return Collection.Find(t => (t.FirstName == name || t.LastName == name)).First();
        }

        public List<Person> FindAllLastName(string name)
        {
            return Collection.Find(t => t.LastName == name).ToList();
        }

        public List<Person> FindAll()
        {
            return Collection.Find(t => t.LastName != null).ToList();
        }
        
    }
}