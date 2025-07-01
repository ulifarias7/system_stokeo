using SistemaStokeo.API.Utilidad;
using Swashbuckle.AspNetCore.Filters;

namespace SistemaStokeo.API.Swagger.Examples
{
    public class InternalErrorExample : IExamplesProvider<Response<Object>>
    {
        public Response<Object> GetExamples()
        {
            return new Response<Object>()
            {
                status = false,
                msg = "Error en el servidor",
                value = null
            };
        }
    }
}
