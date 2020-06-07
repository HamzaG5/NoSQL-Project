using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Data;
using NoSql_Model;

namespace NoSql_DAL
{
    public class Base
    {
        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        private string MongoConnection = "mongodb+srv://root:root@cluster0-yl9ao.mongodb.net/test?retryWrites=true&w=majority";
        private string MongoDatabase = "no_sql_project";

        public Base()
        {
            try
            {
                client = new MongoClient(MongoConnection);
                database = client.GetDatabase(MongoDatabase);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        protected List<BsonDocument> GetDatabaseData(string dbName)
        {
            Base db = new Base();

            List<BsonDocument> dataTable = new List<BsonDocument>();

            try
            {
                //open connection
                IMongoClient newClient = db.ClientGetter();
                IMongoDatabase newDatabase = db.DatabaseGetter(client);
                var collect = newDatabase.GetCollection<BsonDocument>(dbName);
                var documents = collect.Find(new BsonDocument()).ToList();
                foreach (BsonDocument doc in documents)
                {
                    dataTable.Add(doc);
                }
            }
            catch (Exception e)
            {
                return null;
                throw e;
            }
            finally
            {

            }
            return dataTable;
        }

        protected BsonDocument GetSpecificDocument(string dbName, string field, string value, bool isObjectId)
        {
            Base db = new Base();
            BsonDocument specificDocument = new BsonDocument();

            try
            {
                //open connection
                IMongoClient newClient = db.ClientGetter();
                IMongoDatabase newDatabase = db.DatabaseGetter(client);
                
                var collect = newDatabase.GetCollection<BsonDocument>(dbName);

                if (isObjectId == true)
                {
                    ObjectId id = ObjectId.Parse(value); // convert string to object id
                    specificDocument = collect.Find(Builders<BsonDocument>.Filter.Eq(field, id)).FirstOrDefault();
                }
                else
                {
                    specificDocument = collect.Find(Builders<BsonDocument>.Filter.Eq(field, value)).FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                return null;
                throw;
            }
            finally
            {

            }
            return specificDocument;
        }

        

        protected List<BsonDocument> GetSpecificDocumentList(string dbName, string field, string value)
        {
            Base db = new Base();
            List<BsonDocument> specificDocuments = new List<BsonDocument>();

            try
            {
                //open connection
                IMongoClient newClient = db.ClientGetter();
                IMongoDatabase newDatabase = db.DatabaseGetter(client);

                var collect = newDatabase.GetCollection<BsonDocument>(dbName);
                var filter = Builders<BsonDocument>.Filter.Eq(field, value);
                var documents = collect.Find(filter).ToList();

                foreach (BsonDocument doc in documents)
                {
                    specificDocuments.Add(doc);
                }
            }
            catch (Exception e)
            {
                return null;
                throw;
            }
            finally
            {

            }
            return specificDocuments;
        }

        public bool InsertData(BsonDocument data, string dbName)
        {
            Base db = new Base();
            //open connection
            IMongoClient client = db.ClientGetter();
            IMongoDatabase database = db.DatabaseGetter(client);
            //get or create new db 
            var collect = database.GetCollection<BsonDocument>(dbName);
            try
            {
                collect.InsertOneAsync(data);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool DeleteDocument(ObjectId id, string dbName)
        {
            Base db = new Base();
            //open connection
            IMongoClient client = db.ClientGetter();
            IMongoDatabase database = db.DatabaseGetter(client);
            //get or create new db 
            var collect = database.GetCollection<BsonDocument>(dbName);
            try
            {
                var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
                collect.DeleteOne(filter);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool UpdateDocument(string dbName, string id, string field, string value, bool isDate)
        {
            Base db = new Base();
            //open connection
            IMongoClient client = db.ClientGetter();
            IMongoDatabase database = db.DatabaseGetter(client);
            //get or create new db 
            var collect = database.GetCollection<BsonDocument>(dbName);
            try
            {
                var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));

                if (isDate == true)
                {
                    DateTime date = DateTime.Parse(value); //convert string to date
                    collect.UpdateOne(filter, Builders<BsonDocument>.Update.Set(field, date));
                }
                else
                {
                    collect.UpdateOne(filter, Builders<BsonDocument>.Update.Set(field, value));
                }
                
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void UpdateUserData(string dbName, BsonDocument document, string id, string field, string value)
        {
            Base db = new Base();
            //open connection
            IMongoClient client = db.ClientGetter();
            IMongoDatabase database = db.DatabaseGetter(client);
            //get or create new db 
            var collect = database.GetCollection<BsonDocument>(dbName);
            try
            {
                var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
                collect.UpdateOne(filter, Builders<BsonDocument>.Update.Set(field, value));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public BsonDocument GetUserByID(int id)
        {
            Base db = new Base();
            //open connection
            IMongoClient client = db.ClientGetter();
            IMongoDatabase database = db.DatabaseGetter(client);
            //get or create new db 
            var collect = database.GetCollection<BsonDocument>("users");
            try
            {                
                var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
                var result = collect.Find(filter);
                BsonDocument user = (BsonDocument)result;
                return user;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public IMongoClient ClientGetter()
        {
            return new MongoClient(MongoConnection);
        }
        public IMongoDatabase DatabaseGetter(IMongoClient client)
        {
            return client.GetDatabase(MongoDatabase);
        }
        public void DeleteUserByID(string dbName, string userId)
        {
            Base db = new Base();
            //open connection
            IMongoClient client = db.ClientGetter();
            IMongoDatabase database = db.DatabaseGetter(client);
            //get or create new db 
            var collect = database.GetCollection<BsonDocument>(dbName);
            try
            {
                var deleteFilter = Builders<BsonDocument>.Filter.Eq("_id", int.Parse(userId));
                collect.DeleteOne(deleteFilter);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
