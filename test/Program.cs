using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddEnvironmentVariables()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var storageConnectionString = config.GetConnectionString("Storage");

            Console.WriteLine(storageConnectionString);

            var privateKey = config.GetSection("PrivateKey").Value;
            var publicKey = config.GetSection("PublicKey").Value;

            Console.WriteLine($"PublicKey: {publicKey}, PrivateKey: {privateKey}");

            var tpApi = new TigerPawApiHelper(privateKey, publicKey);



        }
    }
}
