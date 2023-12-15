using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net.NetworkInformation;

namespace Howest.Function
{
    public static class getDetection
    {
        [FunctionName("getDetection")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {   
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            detection detection = JsonConvert.DeserializeObject<detection>(requestBody);
            return new OkObjectResult(detection);
        }
    }
}
