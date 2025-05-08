﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaStokeo.BLL.Servicios.Contrato;
using SistemaStokeo.API.Utilidad;
using SistemStokeo.DTO;
using Microsoft.AspNetCore.Authorization;

namespace SistemaStokeo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : ControllerBase
    {
        private readonly IRolServices _rolServicio;

        public RolController(IRolServices rolServicio)
        {
            _rolServicio = rolServicio;
        }

        [Authorize(Roles = "Administrador")]
        [HttpGet]
        [Route("ListaRoles")]
        public async Task<IActionResult> ListaRoles()
        {
            var Rsp = new Response<List<RolDto>>();
            try
            {
                Rsp.status = true;
                Rsp.value = await _rolServicio.List();

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
