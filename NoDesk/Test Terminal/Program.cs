using System;
using MongoDB.Bson;
using NoDeskLogic;
using NoDeskModels;
namespace Test_Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        public void Start()
        {
            // test

            //Company company = new Company
            //{
            //    CompanyName = "Garden Group",
            //    ActivationKey = new ActivationKey { Key = new ObjectId("614e383d3d17e65ed26ba1ad"), UsedStatus = false}
            //};

            // BsonDocument tes = new BsonDocument { { "categories", new BsonElement {} },
            //                                           { "standards", new BsonArray { } }  };


            //Company company = new Company 
            //{
            //    CompanyName = "Garden Group"

            //};

            //User user = new User
            //{
            //    Firstname = "Bastiaan",
            //    Lastname = "van der Bijl",
            //    Email = "666669@student.inholland.nl",
            //    Password = "inholland",

            //    Role = Roles.god,
            //};

            //var recs = ticket_Service.GetTickets();

            //foreach (var rec in recs)
            //{
            //    Console.WriteLine($"{rec.Id} {rec.Subject} {rec.Text}");
            //}

            Encryption test = new Encryption();

            string encrypt = test.Encrypt("Garden Group:NoDesk2021BBJL");

            Console.WriteLine(encrypt);

            Console.ReadKey();
            Console.WriteLine();

            string decrypt = test.Decrypt(encrypt);
            Console.WriteLine(decrypt);
            Console.ReadKey();
        }
    }
}
