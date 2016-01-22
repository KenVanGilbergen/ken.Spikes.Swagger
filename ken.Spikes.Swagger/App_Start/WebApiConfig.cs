using System.Web.Http;

namespace ken.Spikes.Swagger
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            config.Routes.MapHttpRoute(
                name: "HelloWorld",
                routeTemplate: "hello",
                defaults: new { controller = "Hello", action = "Get" }
                );
        }
    }
}