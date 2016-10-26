# helloWorldProject

The files related to this code exam are:

*/HelloWorldProj/Engines/HelloWorldEngine
*/HelloWorldProj/Controllers/HelloWorldController
*/HelloWorldProj.Tests/Controllers/HelloWorldController

and the configs can be found under:

*/HelloWorldProj/

# what this does

When ran locally, hitting http://localhost:56879/api/HelloWorld (or whichever port you choose to run on) will return a simple json object with a text property of "Hello world!" and a createdDate property that will be equal to today.

The test class will send a mock http request and parse the json object out of the response.

