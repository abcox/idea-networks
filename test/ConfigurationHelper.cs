using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace test
{
    class ConfigurationHelper
    {
        private static readonly IConfigurationRoot _config;

        public static IConfiguration Configuration
        {
            get
            {
                return _config ?? new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddEnvironmentVariables()
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();
            }
        }

        public static string ProQuoteConnectionString => Configuration.GetConnectionString("ProQuote");
    }
}
