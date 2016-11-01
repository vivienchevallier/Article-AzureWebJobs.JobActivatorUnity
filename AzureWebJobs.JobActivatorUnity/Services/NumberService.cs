using System;
using AzureWebJobs.JobActivatorUnity.Contracts;

namespace AzureWebJobs.JobActivatorUnity.Services
{
    public class NumberService : INumberService
    {
        private readonly Random random;

        public NumberService()
        {
            this.random = new Random();
        }

        public int GetRandomNumber()
        {
            return this.random.Next();
        }
    }
}
