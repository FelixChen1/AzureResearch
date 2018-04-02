using System;
using Microsoft.Azure.Documents.Client;
using Newtonsoft.Json;

namespace DemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            const string endpointUrl = "https://localhost:8081";
            const string primaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";

            DocumentClient client = new DocumentClient(new Uri(endpointUrl), primaryKey);
        }
    }
}
