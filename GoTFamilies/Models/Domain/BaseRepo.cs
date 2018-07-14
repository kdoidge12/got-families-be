using System;
using GoTFamilies.Models.Data;
using MongoDB.Driver;

namespace GoTFamilies.Models.Domain
{
    public class BaseRepo<TEntityType> where TEntityType: IBaseEntity
    {
        private MongoClient Client;
        private IMongoDatabase Db;
        public IMongoCollection<TEntityType> Collection;

        public BaseRepo(string CollectionId)
        {
            Client = new MongoClient("mongodb://localhost:27017");
            Db = Client.GetDatabase("GameOfThrones");
            Collection = Db.GetCollection<TEntityType>(CollectionId);
        }

        public void Insert(TEntityType entity)
        {
            Collection.InsertOne(entity);
        }

        public void Find(Guid Id)
        {
            Collection.Find(t => t.Id == Id).First();
        }

        public void Update(TEntityType entity)
        {
            Collection.FindOneAndReplace(t => t.Id == entity.Id, entity);
        }

        public void Delete(TEntityType entity)
        {
            Collection.FindOneAndDelete(t => t.Id == entity.Id);
        }
    }
}