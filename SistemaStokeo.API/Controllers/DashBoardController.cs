﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaStokeo.BLL.Servicios.Contrato;
using SistemaStokeo.API.Utilidad;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using SistemStokeo.DTO;
using Microsoft.IdentityModel.Tokens;
using System.Text;

using SistemaStokeo.BLL.Servicios;


namespace SistemaStokeo.API.Controllers
{
    [Route("api/[controller]")]
    //[Authorize]  a esta api solo van a poder entrar usuario autorizados 
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
                Rsp.Value = await _dashBoardservices.Resumen();

            }
            catch (Exception ex)
            {
                Rsp.status = false;
                Rsp.Msg = ex.Message;

            }

            return Ok(Rsp);
        }
    }
}
