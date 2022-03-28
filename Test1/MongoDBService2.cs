using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD = MongoDB.Driver;

namespace Test1
{
    public class MongoDBService2
    {
        static MD.MongoClient dbClient = new MD.MongoClient("mongodb+srv://admin:es16cs22@learnmongo.zmih4.mongodb.net/Student?retryWrites=true&w=majority");

        public static void Create()
        {
            var database = dbClient.GetDatabase("Student");
            var details = database.GetCollection<BsonDocument>("Details");

            var doc = new BsonDocument
            {
                {"name","Ryan"},
                {"age",25 },
                {"mail","ryan@gmail.com" },
                {"phone","9966554467" },
                {"location", "Los Angels" },
                {"job","HR" }
            };

            //var doc2 = new BsonDocument();
            //doc2.Add("name", "John");
            //doc2.Add("age", 26);
            //doc2.Add("hobby", "Watching Movies");
            details.InsertOne(doc);
            
            Console.WriteLine("Successfully inserted \n");
            
            var filter = Builders<BsonDocument>.Filter.Eq("name", "Ryan");
            var person = details.Find(filter).FirstOrDefault();
            Console.WriteLine(person);
        }

        public static void Update()
        {
            var database = dbClient.GetDatabase("Student");
            var details = database.GetCollection<BsonDocument>("Details");

            var find = Builders<BsonDocument>.Filter.Eq("name", "Ryan");
            var update = Builders<BsonDocument>.Update.Set("name", 700);
            Console.WriteLine(details.Find(find).FirstOrDefault());
            Console.ReadLine();
            details.UpdateOne(find, update);
        }

        public static void Delete()
        {
            var database = dbClient.GetDatabase("Student");
            var details = database.GetCollection<BsonDocument>("Details");

            var filter = Builders<BsonDocument>.Filter.Eq("name", "Sam");
            var deletePerson = details.Find(filter).FirstOrDefault();
            Console.WriteLine(deletePerson);
            details.DeleteMany(filter);
        }
    }
}
