using System;
using System.Collections.Generic;
using GoTFamilies.Models.Data.Persons;

namespace GoTFamilies.Models.Data.Families
{
    public class Family : IBaseEntity
    {
        public Guid Id { get; set; }
        public string LastName { get; set; }
        
        public List<Person> Members { get; set; }
    }
}