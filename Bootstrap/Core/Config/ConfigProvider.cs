using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace Bootstrap.Core.Config
{
    public class ConfigProvider
    {
        private static IConfiguration configuration = null;
        public static void SetLocalConfigInfo(IConfiguration config)
        {
            configuration = config;
        }
        public static string MySqlConnectionString
        {

            get
            {
                //ConfigurationManager.AppSettings
                return configuration.GetValue<string>("MySqlConnectionString");
            }

        }
    }
}