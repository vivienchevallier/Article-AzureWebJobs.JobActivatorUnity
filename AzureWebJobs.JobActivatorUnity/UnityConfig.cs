using System;
using AzureWebJobs.JobActivatorUnity.Contracts;
using AzureWebJobs.JobActivatorUnity.Services;
using Microsoft.Practices.Unity;

namespace AzureWebJobs.JobActivatorUnity
{
    public class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<INumberService, NumberService>(new ContainerControlledLifetimeManager());
        }
    }
}