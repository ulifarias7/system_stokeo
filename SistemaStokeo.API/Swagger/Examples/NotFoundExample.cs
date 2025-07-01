using SistemaStokeo.API.Utilidad;
using Swashbuckle.AspNetCore.Filters;

namespace SistemaStokeo.API.Swagger.Examples
{
    public class NotFoundExample : IExamplesProvider<Response<Object>>
    {
        public Response<Object> GetExamples()
        {
            return new Response<Object>()
            {
                status = false,
                msg = "no se encontro el recurso",
                value = null
            };
        }
    }
}
