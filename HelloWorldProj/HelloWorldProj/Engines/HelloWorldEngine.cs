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

        //public void save ()
        //{
        //    //this does nothing for now but it would get the database context, add the new entry to the context, and save the context
        //}

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