using Bootstrap.Core.Config;
using Bootstrap.NHMapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using MySql.Data.MySqlClient;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Engine;
using NHibernate.Metadata;
using NHibernate.Stat;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace Bootstrap.Core
{
    public class MysqlSessionFactoryBuilder
    {
        private static ISessionFactory _instance = null;
        public static ISessionFactory getFactory()
        {
            if (_instance == null)
            {
                Dictionary<string, string> property = new Dictionary<string, string>();

                //仅当需要调试的时候，开启这里
                //property.Add("show_sql", "true");
                //property.Add("format_sql", "true");

                _instance = Fluently.Configure(new Configuration()
                {
                    Properties = property
                })
                  .Database(MySQLConfiguration.Standard
                           .ConnectionString(ConfigProvider.MySqlConnectionString))
                           .Mappings(m => m.FluentMappings.Add<UserMap>())
                           .BuildSessionFactory();
            }
            return _instance;

        }
    }
}
