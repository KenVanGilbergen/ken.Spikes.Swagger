using System;
using IO.Swagger.Api;

namespace swagger.Client.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var api = new DefaultApi("http://localhost:57035/"); //webapi
            //var api = new DefaultApi("http://127.0.0.1:10010/"); //nodejs
            //TODO: find out why errors with generated code... Configuration.Default.ApiClient
            var api = new DefaultApi(); 
            var response = api.Hello("Foobar");
            Console.WriteLine(response.Message);
            Console.ReadLine();
        }
    }
}
