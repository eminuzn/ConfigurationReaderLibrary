using System;
using Xunit;

namespace ConfigurationReader.Test
{
    public class ConfigurationReaderTest
    {
        Library.ConfigurationReader configurationReader;

        public ConfigurationReaderTest()
        {
            configurationReader = new Library.ConfigurationReader("SERVICE-A", "mongodb://localhost:27017", 5000);
        }

        [Fact]
        public void ConfigurationCorrectionTest()
        {
            bool IsBasketEnabled = configurationReader.GetValue<bool>("IsBasketEnabled");
            Assert.Equal(true, IsBasketEnabled);
        }
    }
}
