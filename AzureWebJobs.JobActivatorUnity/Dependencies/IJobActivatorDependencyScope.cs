using System;
using Microsoft.Azure.WebJobs.Host;

namespace AzureWebJobs.JobActivatorUnity.Dependencies
{
    public interface IJobActivatorDependencyScope : IJobActivator, IDisposable
    {
    }
}
