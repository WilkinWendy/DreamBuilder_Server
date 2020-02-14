using Bootstrap.Core;
using Microsoft.Extensions.Configuration;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unity;
using Unity.RegistrationByConvention;

namespace Bootstrap.Core.UnityConfig
{
    public class UnityConfig
    {
        public static IUnityContainer currentContainer = null;
        public static void Init() {
            IUnityContainer container = new UnityContainer();
            currentContainer = container;
            RegisterTypes(container);   
        }
        
        private static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterInstance(MysqlSessionFactoryBuilder.getFactory());
        }
    }
}
