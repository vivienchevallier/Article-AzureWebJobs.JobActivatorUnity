using System;
using AzureWebJobs.JobActivatorUnity.Dependencies;
using Microsoft.Practices.Unity;

namespace AzureWebJobs.JobActivatorUnity.Unity
{
    public class UnityJobActivatorDependencyScope : IJobActivatorDependencyScope
    {
        private readonly IUnityContainer container;

        public UnityJobActivatorDependencyScope(IUnityContainer container)
        {
            if (container == null) throw new ArgumentNullException("container");

            this.container = container;
        }

        public T CreateInstance<T>()
        {
            return this.container.Resolve<T>();
        }

        public void Dispose()
        {
            this.container.Dispose();
        }
    }
}
