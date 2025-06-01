using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaStokeo.BLL.Servicios.Contrato;
using SistemaStokeo.API.Utilidad;
using Microsoft.AspNetCore.Authorization;
using SistemStokeo.DTO;

namespace SistemaStokeo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashBoardController : ControllerBase
    {

        private readonly IDashBoardservices _dashBoardservices;

        public DashBoardController(IDashBoardservices dashBoardservices)
        {
            _dashBoardservices = dashBoardservices;
        }

        [Authorize(Roles = "Administrador,Empleado,supervisor")]
        [HttpGet]
        [Route("Resumen")]

        public async Task<IActionResult> Resumen()
        {
            var Rsp = new Response<DashBoardDto>();
            try
            {
                Rsp.status = true;
                Rsp.value = await _dashBoardservices.Resumen();

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
