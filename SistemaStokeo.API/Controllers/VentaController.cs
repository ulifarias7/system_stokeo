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
    public class VentaController : ControllerBase
    {
        private readonly IVentaservices _ventaservices;

        public VentaController(IVentaservices ventaservices)
        {
            _ventaservices = ventaservices;
        }

        [Authorize(Roles = "Administrador,Empleado,supervisor")]
        [HttpPost]
        [Route("registrarventa")]

        public async Task<IActionResult> RegistrarVenta([FromBody] VentaDto venta)
        {
            var Rsp = new Response<VentaDto>();
            try
            {
                Rsp.status = true;
                Rsp.value = await _ventaservices.RegistrarVenta(venta);

            }
            catch (Exception ex)
            {
                Rsp.status = false;
                Rsp.msg = ex.Message;

            }

            return Ok(Rsp);
        }


        [Authorize(Roles = "Administrador,Empleado,supervisor")]
        [HttpGet]
        [Route("ListaVenta")]
        public async Task<IActionResult> ListaVenta(string? Buscarpo,string? Numerodeventa,string? fechadeinicio,string? fechadefin )
        {
            var Rsp = new Response<List<VentaDto>>();
            Numerodeventa = Numerodeventa is null ? "" : Numerodeventa;
            fechadeinicio = fechadeinicio is null ? "" : fechadeinicio;
            fechadefin = fechadefin is null ? "" : fechadefin;
            try
            {
                Rsp.status = true;
                Rsp.value = await _ventaservices.Historial(Buscarpo,Numerodeventa,fechadeinicio,fechadefin);

            }
            catch (Exception ex)
            {
                Rsp.status = false;
                Rsp.msg = ex.Message;

            }

            return Ok(Rsp);
        }


        [Authorize(Roles = "Administrador,Empleado,supervisor")]
        [HttpGet]
        [Route("ReporteVenta")]
        public async Task<IActionResult> ReporteVenta(string? fechadeinicio, string? fechadefin)
        {
            var Rsp = new Response<List<ReporteDto>>();
            fechadeinicio = fechadeinicio is null ? "" : fechadeinicio;
            fechadefin = fechadefin is null ? "" : fechadefin;
            try
            {
                Rsp.status = true;
                Rsp.value = await _ventaservices.Reporte(fechadeinicio, fechadefin);

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
