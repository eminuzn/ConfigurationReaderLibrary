using ConfigurationReader.Library.Models;
using ConfigurationReader.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationReader.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private IMongoDatabase mongoDb { get; set; }

        public HomeController(IConfiguration appSettings)
        {
            IMongoClient client = new MongoClient(appSettings.GetValue<string>("MongoDbConnStr"));
            mongoDb = client.GetDatabase(appSettings.GetValue<string>("MongoDbDatabase"));
        }

        public IActionResult Index()
        {
            List<Configuration> configurationList = mongoDb.GetCollection<Configuration>("Configuration").Find(x => true).ToList();

            return View(configurationList);
        }

        public IActionResult CreateUpdate(string id)
        {
            Configuration configurationItem = new Configuration();
            if (id != null)
            {
                configurationItem = mongoDb.GetCollection<Configuration>("Configuration").Find(x => x.Id == id).FirstOrDefault();
            }
            return View(configurationItem);
        }

        [HttpPost]
        public IActionResult CreateUpdate(Configuration configuration)
        {

            if (configuration.Id == null)
            {
                mongoDb.GetCollection<Configuration>("Configuration").InsertOne(configuration);
            }
            else
            {
                mongoDb.GetCollection<Configuration>("Configuration").ReplaceOne(x=>x.Id == configuration.Id, configuration);
            }

            return RedirectToAction("Index");
        }

    }
}
