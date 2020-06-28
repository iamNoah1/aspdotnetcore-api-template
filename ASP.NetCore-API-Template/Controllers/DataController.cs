using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace ASP.NetCore_API_Template.Controllers
{
    [Route("api/[controller]")]
    public class DataController : ControllerBase
    {
        [HttpPost]
        public void Post(JObject data)
        {
        }
    }
}
