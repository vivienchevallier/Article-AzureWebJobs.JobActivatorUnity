using System;
using System.IO;
using AzureWebJobs.JobActivatorUnity.Contracts;
using Microsoft.Azure.WebJobs;

namespace AzureWebJobs.JobActivatorUnity
{
    public class Functions
    {
        private readonly INumberService numberService;

        public Functions(INumberService numberService)
        {
            if (numberService == null) throw new ArgumentNullException("numberService");

            this.numberService = numberService;
        }

        // This function will get triggered/executed when a new message is written 
        // on an Azure Queue called queue.
        public void ProcessQueueMessage([QueueTrigger("queue")] string message, TextWriter log)
        {
            log.WriteLine("New random number {0} for message: {1}", this.numberService.GetRandomNumber(), message);
        }
    }
}