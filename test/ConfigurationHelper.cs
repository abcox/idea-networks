using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace test
{
    class ConfigurationHelper
    {
        public enum Environment
        {
            Production,
            Sandbox
        }
        private static IConfigurationRoot _config = null;
        private Environment _environment;

        public ConfigurationHelper(Environment environment)
        {
            _config = null;
            _environment = environment;
        }

        public ConfigurationHelper()
        {
            _config = null;
            _environment = Environment.Sandbox;
        }

        public Environment EnvironmentSelected
        {
            get
            {
                return _environment;
            }
            set
            {
                _environment = value;
            }
        }

        public string EnvironmentString
        {
            get
            {
                return EnvironmentSelected.ToString();
            }
        }

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

        public string ProQuoteConnectionString => Configuration.GetConnectionString("ProQuote");
        public string TigerDashConnectionString => Configuration.GetConnectionString("TigerDash");
        public string ApiBaseUrl => Configuration.GetSection($"{EnvironmentString}:baseUrl").Value;
        public string ApiPrivateKey => Configuration.GetSection($"{EnvironmentString}:privateKey").Value;
        public string ApiPublicKey => Configuration.GetSection($"{EnvironmentString}:publicKey").Value;
    }
}
