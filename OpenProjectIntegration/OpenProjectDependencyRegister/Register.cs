using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using Unity.Injection;
using Unity.Lifetime;
using OpenProjectDataContext;
using OpenProjectIntegrationClassLibrary.Configurations;
using OpenProjectDataContext.DataBaseFactory;
using OpenProjectDataContext.Migrations.Running;

namespace OpenProjectDependencyRegister
{
    public class Register
    {
        public static void RegisterObjectInContainer(UnityContainer container)
        {
            RegisterMigration(container);
            //RegisterRepositories(container);
        }

        private static void RegisterMigration(UnityContainer container)
        {
            container.RegisterType<IDatabaseAdapter, DatabaseAdapterSQLite>(new HierarchicalLifetimeManager());
            container.RegisterType<IMigrationWinAppRunner, MigrationRunnerWinApp>(new HierarchicalLifetimeManager());
        }
    }
}
