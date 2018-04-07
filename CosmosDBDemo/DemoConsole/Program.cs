using System;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Newtonsoft.Json;

namespace DemoConsole
{
    class Program
    {
        private const string EndpointUrl = "https://localhost:8081";
        private const string PrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";
        private const string GroupDB = "GroupDB";
        private const string GroupDefinitionCollection = "GroupDefinition";
        private const string GroupCollection = "Group";
        private const string AccountCollection = "Account";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using(var client = new DocumentClient(new Uri(EndpointUrl), PrimaryKey))
            {
                try
                {
                    CreateDatabase(client).Wait();
                }
                finally
                {
                    DeleteDatabase(client).Wait();
                }
            }

        }

        private static async Task InitilizeGroups()
        {

        }

        private static async Task CreateDatabase(DocumentClient client)
        {
            await client.CreateDatabaseIfNotExistsAsync(new Database { Id = GroupDB });

            await client.CreateDocumentCollectionIfNotExistsAsync(UriFactory.CreateDatabaseUri(GroupDB),
                new DocumentCollection { Id = GroupDefinitionCollection });
            await client.CreateDocumentCollectionIfNotExistsAsync(UriFactory.CreateDatabaseUri(GroupDB),
                new DocumentCollection { Id = GroupCollection });
            await client.CreateDocumentCollectionIfNotExistsAsync(UriFactory.CreateDatabaseUri(GroupDB),
                new DocumentCollection { Id = AccountCollection });
        }

        private static async Task DeleteDatabase(IDocumentClient client)
        {
            await client.DeleteDatabaseAsync(UriFactory.CreateDatabaseUri(GroupDB));
        }

    }
}