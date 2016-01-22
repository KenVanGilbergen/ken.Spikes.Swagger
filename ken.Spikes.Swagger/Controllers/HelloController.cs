using System;
using System.Web.Http;

namespace ken.Spikes.Swagger.Controllers
{
    public class HelloController : ApiController
    {
        public IHttpActionResult Get(string name)
        {
            var hello = String.Format("Hello, {0}!", name);
            return Json(hello);
        }
    }
}
