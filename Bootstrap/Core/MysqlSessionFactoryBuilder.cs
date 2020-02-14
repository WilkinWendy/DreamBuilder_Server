using Bootstrap.NHMapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using MySql.Data.MySqlClient;
using NHibernate;
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
            //using (MySqlConnection conn = new MySqlConnection("server=localhost:3306;user=root;pwd=123456;database=dreambuilder"))
            //{
            //    conn.Open();


            //    conn.CreateCommand();
            //    //conn.
            //}


            if (_instance == null)

            {
                _instance = Fluently.Configure()
                  .Database(MySQLConfiguration.Standard
                           .ConnectionString("server=localhost;port=3306;user=root;pwd=123456;database=dreambuilder"))
                           .Mappings(m => m.FluentMappings.Add<UserMap>())
                           .BuildSessionFactory();
            }
            return _instance;

        }
    }
}
