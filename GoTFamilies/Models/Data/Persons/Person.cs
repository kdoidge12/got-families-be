using System;
using System.Collections.Generic;
using GoTFamilies.Models.Data.Contracts.Persons;
using GoTFamilies.Models.Data.Families;

namespace GoTFamilies.Models.Data.Persons
{
    public class Person : IBaseEntity
    {
        public Guid Id { get; set; }
        public string FirstName {get;set;}
        public string LastName { get; set; }
        public string Description { get; set; }
        public List<Family> Families { get; set; }

        public Person(PersonDTO person)
        {
            FirstName = person.FirstName;
            LastName = person.LastName;
        }
    }
}