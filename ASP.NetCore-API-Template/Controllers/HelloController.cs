using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace ASP.NetCore_API_Template.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        public IActionResult SayHello()
        {
            JObject responseBody = new JObject();
            responseBody.Add(new JProperty("message", "hello"));
            return new OkObjectResult(responseBody);
        }
    }
}