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
    public static class addLocation
    {
        [FunctionName("addLocation")]
        public static async Task<IActionResult> AddLocation(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)] HttpRequest req,
            ILogger log)
        {

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            

            Location location = JsonConvert.DeserializeObject<Location>(requestBody);

            return new OkObjectResult(location);
        }
    }
}
