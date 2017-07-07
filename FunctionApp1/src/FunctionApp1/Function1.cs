using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.ServiceBus.Messaging;

namespace FunctionApp1
{
    public static class Function1
    {
        [FunctionName("ServiceBusTopicTriggerCSharp")]
        public static void Run([ServiceBusTrigger("mytopic", "AzureFunctionsSub", AccessRights.Manage, Connection = "AzureWebJobsSBConnectionString")]string mySbMsg, TraceWriter log)
        {
            log.Info($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
        }
    }
}