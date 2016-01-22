using System;
using System.Web.Http;

namespace ken.Spikes.Swagger.Controllers
{
    public class HelloController : ApiController
    {
        public string Get(string name)
        {
            return String.Format("Hello, {0}!", name);
        }
    }
}
