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
            Encryption test = new Encryption();

            string encrypt = test.Encrypt("NoDesk:NoDesk2021BBJL");

            Console.WriteLine(encrypt);

            Console.ReadKey();
            Console.WriteLine();

            string decrypt = test.Decrypt(encrypt);
            Console.WriteLine(decrypt);



            Console.ReadKey();
        }
    }
}
