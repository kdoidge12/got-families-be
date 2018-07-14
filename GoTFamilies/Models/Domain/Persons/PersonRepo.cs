using System.Collections.ObjectModel;
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
        
    }
}