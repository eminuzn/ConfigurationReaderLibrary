using ConfigurationReader.Library.Interfaces;
using MongoDB.Driver.Core.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigurationReader.Library.Models;

namespace ConfigurationReader.Library.ConfigurationProviders
{
    public class MongoConfigurationProvider : IConfigurationProvider
    {
        private IMongoDatabase mongoDatabase;
        private string applicationName;
        public MongoConfigurationProvider(string applicationName, string connStr)
        {
            this.applicationName = applicationName;
            IMongoClient client = new MongoClient(connStr);
            mongoDatabase = client.GetDatabase("ConfigurationCodeCase");
        }

        public List<Configuration> GetConfigurationList()
        {
            IMongoCollection<Configuration> configurationCollection = mongoDatabase.GetCollection<Configuration>("Configuration");

            return configurationCollection.Find<Configuration>(x => x.IsActive && x.ApplicationName == this.applicationName).ToList();
        }
    }
}
