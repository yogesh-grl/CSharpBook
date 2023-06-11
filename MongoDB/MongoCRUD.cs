using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB
{
    internal class MongoCRUD
    {
        private IMongoDatabase db;
        string connectionString = "mongodb://localhost:27017";
        public MongoCRUD(string dataBase)
        {
            var client = new MongoClient(connectionString);
            db = client.GetDatabase(dataBase);
        }

        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        public void LoadRecords<T>(string table)
        {
            var collections = db.GetCollection<T>(table);
            var data = collections.Find(new BsonDocument()).ToList();
        }

    }
}
