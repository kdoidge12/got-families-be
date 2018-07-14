using GoTFamilies.Models.Data.Families;
using Microsoft.WindowsAzure.Storage.Table;

namespace GoTFamilies.Models.Domain.Families
{
    public class FamilyRepo : BaseRepo<Family>
    {
        public FamilyRepo() : base("Families")
        {
            
        }
    }
}