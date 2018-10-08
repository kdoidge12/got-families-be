using System;
using GoTFamilies.Models.Data.Families;
using GoTFamilies.Models.Domain;
using GoTFamilies.Models.Domain.Families;

namespace GoTFamilies.Managers
{
    public class FamilyManager :BaseManager<Family>
    {
        private readonly FamilyRepo famRepo;
        public FamilyManager(BaseRepo<Family> repo) :base(repo)
        {
            famRepo = repo as FamilyRepo;
        }
    }
}
