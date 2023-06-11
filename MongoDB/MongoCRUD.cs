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

        public void LoadRecordByID<T>(string table, Guid ID)
        {
            var collections = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", ID);
            var data = collections.Find(filter).ToList();
        }

        public void Upsert<T>(string table, Guid Id, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.ReplaceOne(new BsonDocument("_id", Id),
                record,
                new UpdateOptions { IsUpsert = true });
        }

        public void DeleteRecord<T>(string table, Guid id)
        {
            var collectionb = db.GetCollection<T>(table);
            collectionb.DeleteOne(new BsonDocument("_id", id));

            LoadRecords<T>(table);
        }

        public void InsertMany<T>(string table, List<T> LsRecords)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertMany(LsRecords);
        }

    }
}
