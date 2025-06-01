using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaStokeo.BLL.Servicios.Contrato;
using SistemaStokeo.API.Utilidad;
using SistemStokeo.DTO;
using Microsoft.AspNetCore.Authorization;

namespace SistemaStokeo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaServices _categoriaServices;

        public CategoriaController(ICategoriaServices categoriaServices)
        {
            _categoriaServices = categoriaServices;
        }


        [Authorize(Roles ="Administrador,Empleado,supervisor")]
        [HttpGet]
        [Route("ListaCategoria")]

        public async Task<IActionResult> ListaCategoria()
        {
            var Rsp = new Response<List<CategoriaDto>>();
            try
            {
                Rsp.value = await _categoriaServices.ListCategoria();
                Rsp.status = true;
            }
            catch (Exception ex)
            {
                Rsp.status = false;
                Rsp.msg = "no se encontro ninguna categoria";

            }
            return Ok(Rsp);
        }



        [Authorize(Roles = "Administrador")]
        [HttpPost]
        [Route("CrearCategoria")]

        public async Task<IActionResult> CrearCategoria([FromBody] CategoriaDto crearcategoria)
        {
            var Rsp = new Response<CategoriaDto>();
            try
            {
                Rsp.status = true;
                Rsp.value = await _categoriaServices.CrearCategoria(crearcategoria);

            }
            catch (Exception ex)
            {
                Rsp.status = false;
                Rsp.msg = ex.Message;

            }
            return Ok(Rsp);
        }
    }
}
