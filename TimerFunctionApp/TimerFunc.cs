using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace TimerFunctionApp
{
    public static class TimerFunc
    {
        [FunctionName("TimerFunc")]
        public static void Run(
            [TimerTrigger("%ScheduleTriggerTime%")] TimerInfo myTimer,
            ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
