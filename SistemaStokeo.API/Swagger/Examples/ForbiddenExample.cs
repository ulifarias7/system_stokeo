using SistemaStokeo.API.Utilidad;
using Swashbuckle.AspNetCore.Filters;

namespace SistemaStokeo.API.Swagger.Examples
{
    public class ForbiddenExample : IExamplesProvider<Response<Object>>
    {
        public Response<Object> GetExamples()
        {
            return new Response<Object>()
            {
                status = false,
                msg = "erro del servicio",
                value = null
            };
        }
    }
}
