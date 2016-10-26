using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorldProj
{
    public class HelloWorldEngine
    {
        public HelloWorldObject getHelloWorldObject()
        {
            HelloWorldObject helloWorldObject = new HelloWorldObject();
            return helloWorldObject;
        }

    }

    public class HelloWorldObject
    {
        public String text
        {
            get { return "Hello world!"; }
        }

        public DateTime createdDate
        {
            get { return DateTime.Today; }
        }
    }
}