using BIWEBAPI.DataContracts.Models;
using BIWEBAPI.DataContracts.Repositories;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIWEBAPI.Data.Repositories
{
    public class SkipRepository : ISkipRepository
    {

        private readonly IMongoCollection<SkipOn> _SkipCollection;
        public SkipRepository(IOptions<MongoDBSettings> mongoDBSettings)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
            IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
            _SkipCollection = database.GetCollection<SkipOn>(mongoDBSettings.Value.CollectionName);
        }

        public async Task AddNewCollectionData(SkipOn skipOn)
        {
           await _SkipCollection.InsertOneAsync(skipOn);
        }

        public async Task<List<SkipOn>> GetAlldetails()
        {
            var data = await _SkipCollection.Find(s => true).ToListAsync();
            return data;
        }
    }
}
