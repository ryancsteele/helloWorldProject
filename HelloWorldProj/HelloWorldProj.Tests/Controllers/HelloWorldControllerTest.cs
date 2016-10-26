using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldProj;
using HelloWorldProj.Controllers;
using Newtonsoft.Json;


namespace HelloWorldProj.Tests.Controllers
{
    [TestClass]
    public class HelloWorldControllerTest
    {
        [TestMethod]
        public void TestGetHelloWorld()
        {
            try
            {
                //create a constant that will be used to test the output of the helloworldobject response...
                const String HELLO_WORLD_STRING = "Hello world!";
                //init controller
                HelloWorldController helloWorldController = new HelloWorldController();
                //create mock http request
                helloWorldController.Request = new HttpRequestMessage();
                helloWorldController.Configuration = new HttpConfiguration();
                //get the response
                HttpResponseMessage response = helloWorldController.getHelloWorld();
                //serialize content value to an output string
                string output = JsonConvert.SerializeObject(response.Content);
                //reconstitute the HelloWorldObject with the output
                HelloWorldObject helloWorldResponse = JsonConvert.DeserializeObject<HelloWorldObject>(output);
                //assert the things
                Assert.AreEqual(response.StatusCode, System.Net.HttpStatusCode.OK);
                Assert.AreEqual(helloWorldResponse.text, HELLO_WORLD_STRING);
                Assert.AreEqual(helloWorldResponse.createdDate, DateTime.Today);
            }
            finally{
                //clean up logic would go here
                System.Diagnostics.Debug.WriteLine("Test executed successfully");
            }

        }

    }
}
