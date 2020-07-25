using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace ASP.NetCore_API_Template.Controllers
{
    [Route("api/[controller]")]
    public class DataController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(JObject data)
        {
            if (data == null || data.ToString().Equals("{}"))
            {
                JObject responseJson = new JObject();
                ObjectResult objectResult;
                responseJson.Add(new JProperty("errorMessage", "Request body is empty or not set at all"));
                objectResult = new ObjectResult(responseJson);
                objectResult.StatusCode = (int)HttpStatusCode.BadRequest;

                return objectResult;
            }
            try
            {
                return new OkResult();
            }
            catch (Exception e)
            {
                JObject responseJson = new JObject();
                responseJson.Add(new JProperty("errorMessage", e.Message));
                var objectResult = new ObjectResult(responseJson);
                objectResult.StatusCode = (int)HttpStatusCode.InternalServerError;
                return objectResult;
            }
        }
    }
}
