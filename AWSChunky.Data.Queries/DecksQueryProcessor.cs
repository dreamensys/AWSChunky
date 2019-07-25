using AWSChunky.Data.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSChunky.Data.Queries
{
    public class DecksQueryProcessor : IDecksQueryProcessor
    {
        private readonly IMongoDatabase db;
        
        public DecksQueryProcessor(IChunkyDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            db = client.GetDatabase(settings.DatabaseName);
                      
        }

        private IMongoCollection<Deck> GetAll()
        {
            return db.GetCollection<Deck>("Decks");
        }
        public IEnumerable<Deck> Get()
        {
            var _decks = GetAll().Find(new BsonDocument()).ToList();
            return _decks;
        }

        public void Update(string id, Deck _deck)
        {
            GetAll().ReplaceOne(d => d.Id == id, _deck);
        }
        public Deck Get(string id)
        {
            return GetAll().Find<Deck>(d => d.Id == id).FirstOrDefault();
        }
        public Task Delete(string id)
        {
          return Task.Run(()=>GetAll().DeleteOne(d => d.Id == id));
        }

        

        public async Task Create(Deck deck)
        {
            await db.GetCollection<Deck>("Decks").InsertOneAsync(deck);
        }
    }
}
