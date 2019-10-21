using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;
using Unity.Lifetime;

namespace DependencyRegister
{
    public class Register
    {
        public static void RegisterObjectInContainer(UnityContainer container)
        {
            RegisterRepository(container);
        }
        private static void RegisterRepository(UnityContainer container)
        {
            container.RegisterType<IRestClient, RestClient>(new HierarchicalLifetimeManager(), new InjectionConstructor());
            container.RegisterType<IRestRequest, RestRequest>(new HierarchicalLifetimeManager(), new InjectionConstructor());
        }
    }
}
