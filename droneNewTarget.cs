using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Howest.Function
{
    public static class droneNewTarget
    {
        [FunctionName("droneNewTarget")]
        public static async Task<IActionResult> DroneNewTarget(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "/deviceId/countrycode/targetId")] HttpRequest req,
            ILogger log)
        {
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            
            Location location = JsonConvert.DeserializeObject<Location>(requestBody);
            return new OkObjectResult(location);
        }
    }
}
