using System.Web.Http;
using Swashbuckle.Application;

namespace ken.Spikes.Swagger
{
    public class SwaggerConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config
                .EnableSwagger(c => c.SingleApiVersion("v1", "Hello world"))
                .EnableSwaggerUi();
        }
    }
}