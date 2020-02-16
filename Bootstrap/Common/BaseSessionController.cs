using Bootstrap.Core.UnityConfig;
using Microsoft.AspNetCore.Mvc;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unity;

namespace Bootstrap.Controllers
{
    public class BaseSessionController : ControllerBase
    {
        public static ISessionFactory sessionFactory
        {
            get
            {
                return UnityConfig.currentContainer.Resolve<ISessionFactory>();
            }
        }
    }
}
