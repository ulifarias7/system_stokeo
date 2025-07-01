using Microsoft.AspNetCore.Mvc;
using SistemaStokeo.API.Utilidad;

namespace SistemaStokeo.API.Swagger.Attribute
{
    [AttributeUsage(AttributeTargets.Method)]
    public class StandarResponsesAttribute : ProducesResponseTypeAttribute
    {
        public StandarResponsesAttribute() : base(typeof(Response<Object>), StatusCodes.Status200OK) { }
        public string ResponseDescription { get; set; } = "Objeto";
    }
}

