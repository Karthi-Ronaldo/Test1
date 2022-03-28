using MD = MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Net.Mail;

namespace Test1
{
    
    class MongoDbService
    {
        static MD.MongoClient dbClient = new MD.MongoClient("mongodb+srv://admin:es16cs22@learnmongo.zmih4.mongodb.net/Student?retryWrites=true&w=majority");

        public static void MongoServices()
        {
            var database = dbClient.GetDatabase("Student");
            var details = database.GetCollection<BsonDocument>("Details");

            //var doc = new BsonDocument
            //{
            //    {"name","Arjun"},
            //    {"age",30 },
            //    {"mail","arjun@gmail.com" },
            //    {"phone","7766554422" },
            //    {"location", "chennai" },
            //    {"job","Architect" }
            //};
            //var doc2 = new BsonDocument();
            //doc2.Add("name", "John");
            //doc2.Add("age", 26);
            //doc2.Add("hobby", "Watching Movies");
            //details.InsertOne(doc2);

            //var doc3 = new { name = "Sam", age = "19", salary = "$50000", mails = new { mail = "sam@gmail.com", alterMail =  "sam2@gmail.com"} };
            //details.InsertOne(doc3.ToBsonDocument());

            //var findSam = Builders<BsonDocument>.Filter.Eq("name", "Sam");
            //var updateSam = Builders<BsonDocument>.Update.Set("mail", new BsonDocument { { "mail", 20 } });
            //Console.WriteLine(details.Find(findSam).FirstOrDefault());
            //details.UpdateOne(findSam, updateSam);

            //var isDeleted = Builders<BsonDocument>.Filter.Eq("isdeleted", true);
            //var salaryPerson = details.Find(isDeleted).FirstOrDefault();

            //Console.WriteLine(salaryPerson);

            //details.DeleteOne(isDeleted);

            var isTeeenAger = Builders<BsonDocument>.Filter.ElemMatch<BsonValue>(
                "mails",
                new BsonDocument { { "mail",
                        new BsonDocument { { "$lte", 20 } } } });

            var teenAgers = details.Find(isTeeenAger).ToCursor();

            //var students = details.Find(_ => true).ToList(); // Get all records

            //var isTeenAger = Builders<BsonDocument>.Filter.Lte("age", 20);
            //var teenAgers = details.Find(isTeenAger).ToCursor();
            foreach (var item in teenAgers.ToEnumerable())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Above are Teenagres in DB");
        }
    }
}
