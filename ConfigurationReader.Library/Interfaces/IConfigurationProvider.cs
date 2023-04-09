using ConfigurationReader.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationReader.Library.Interfaces
{
    internal interface IConfigurationProvider
    {
        List<Configuration> GetConfigurationList();
    }
}
