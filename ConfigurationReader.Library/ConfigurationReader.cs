using Amazon.Runtime.Internal.Util;
using ConfigurationReader.Library.ConfigurationProviders;
using ConfigurationReader.Library.Interfaces;
using ConfigurationReader.Library.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationReader.Library
{
    public class ConfigurationReader
    {
        private IConfigurationProvider configurationProvider;
        private List<Configuration> configurationList;

        public ConfigurationReader(string applicationName, string connectionString, int refreshTimerIntervalInMs)
        {
            configurationProvider = new MongoConfigurationProvider(applicationName, connectionString);

            RefreshConfigurationList();

            Task.Run(async () =>
            {
                await Task.Delay(refreshTimerIntervalInMs);
                RefreshConfigurationList();
            });
        }

        public T GetValue<T>(string key)
        {
            if (configurationList == null)
            {
                throw new Exception("ConfigurationList is unavailable");
            }

            Configuration configurationItem = configurationList.FirstOrDefault(x => x.Name == key);

            if (configurationItem == null)
            {
                throw new Exception("Data for the entered configuration could not be found");
            }

            if (typeof(T)==typeof(bool))
            {
                configurationItem.Value = configurationItem.Value == "1" ? "true" : "false";
            }

            return (T)Convert.ChangeType(configurationItem.Value, typeof(T));
        }

        private void RefreshConfigurationList()
        {
            List<Configuration> result = new List<Configuration>();

            try
            {
                this.configurationList = configurationProvider.GetConfigurationList();
            }
            catch (Exception ex)
            {
                //Kullanılacak sistemde logger vs kullanılıp kullanılmayacaını bilmediğimden ve sistem sadece dediğiniz 3 parametre ile initialize olacaından log kısmını boş bırakıyorum.
            }
        }
    }
}
