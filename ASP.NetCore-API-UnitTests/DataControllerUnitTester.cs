using System;
using ASP.NetCore_API_Template.Controllers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Xunit;

namespace ASP.NetCore_API_UnitTests
{
    public class DataControllerUnitTester
    {
        [Fact]
        public void PostEndpointShouldReturn400IfBodyWasEmpty()
        {
            DataController controllerUnderTest = new DataController();
            ObjectResult response = (ObjectResult) controllerUnderTest.Post(new JObject());
            Assert.Equal(400, response.StatusCode);
        }

        [Fact]
        public void PostEndpointShouldReturn400IfBodyWasNull()
        {
            DataController controllerUnderTest = new DataController();
            ObjectResult response = (ObjectResult)controllerUnderTest.Post(null);
            Assert.Equal(400, response.StatusCode);
        }

        [Fact]
        public void PostEndpointShouldReturn200IfRequestWasSuccessfull()
        {
            DataController controllerUnderTest = new DataController();

            JObject requestBody = new JObject();
            requestBody.Add(new JProperty("somekey", "somevalue"));

            OkResult response = (OkResult)controllerUnderTest.Post(requestBody);
            Assert.Equal(200, response.StatusCode);
        }
    }
}
