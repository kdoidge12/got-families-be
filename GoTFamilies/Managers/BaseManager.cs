using System;
using GoTFamilies.Models.Data;
using GoTFamilies.Models.Domain;

namespace GoTFamilies.Managers
{
    public class BaseManager<TType> where TType: IBaseEntity
    {
        private readonly BaseRepo<TType> repo;
        public BaseManager(BaseRepo<TType> repo)
        {
            this.repo = repo;
        }

        public void Insert(TType entity)
        {
            repo.Insert(entity);
        }

        public void Get(Guid id)
        {
            repo.Find(id);
        }

        public void Update(TType entity)
        {
            repo.Update(entity);
        }

        public void Delete(TType entity)
        {
            repo.Delete(entity);
        }
    }
}
