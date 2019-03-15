using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace test
{
    class ConfigurationHelper
    {
        private static IConfigurationRoot _config = null;

        public ConfigurationHelper() { _config = null; }

        public static IConfiguration Configuration
        {
            get
            {
                if (_config == null)
                    _config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddEnvironmentVariables()
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();
                return _config;
            }
        }

        public static string ProQuoteConnectionString => Configuration.GetConnectionString("ProQuote");
    }
}
