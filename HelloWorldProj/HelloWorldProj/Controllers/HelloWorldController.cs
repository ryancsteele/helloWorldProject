using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Net.Http.Formatting;

namespace HelloWorldProj.Controllers
{
    public class HelloWorldController : ApiController
    {
        //initializes the HelloWorldEngine       
        public HelloWorldEngine engine = new HelloWorldEngine();

        //public web api method to return the string hello world to the user's device
        public HttpResponseMessage getHelloWorld()
        {            
            //get hello world object
            HelloWorldObject helloWorldObject = engine.getHelloWorldObject();
            //print "Hello world!" to the console
            System.Diagnostics.Debug.WriteLine(helloWorldObject.text);
            //return the object in the http response so that anything that calls this can have it            
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, helloWorldObject);
            response.Content = new ObjectContent<HelloWorldObject>(helloWorldObject, new JsonMediaTypeFormatter(), "application/json");
            return response;
        }

    }
}
