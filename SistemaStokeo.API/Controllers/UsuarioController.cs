using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaStokeo.BLL.Servicios.Contrato;
using SistemaStokeo.API.Utilidad;
using SistemStokeo.DTO;
using SistemaStokeo.BLL.Servicios;
using SistemaStokeo.DAL.DBContext;
using SistemaStokeo.MODELS;
using Microsoft.AspNetCore.Authorization;
using System.Security.Cryptography;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.EntityFrameworkCore;
using SistemaStokeo.UTILITYS;



namespace SistemaStokeo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuarioServices _Usuarioservices;
        private readonly Cryptoo _crypto;
       

        public UsuarioController(IUsuarioServices usuarioservices, Cryptoo crypto)
        {
            _Usuarioservices = usuarioservices;
            _crypto = crypto;
           
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("Registrarse")]

        public async Task<IActionResult> Registrarse([FromBody] UsuarioDto usuario)
        {
            var Rsp = new Response<UsuarioDto>();

            try
            {
                usuario.Clave = _crypto.encriptarSHA256(usuario.Clave);
                Rsp.status = true;
                Rsp.value = await _Usuarioservices.Crear(usuario);

            }
            catch (Exception ex)
            {
                Rsp.status = false;
                Rsp.msg = ex.Message;

            }

            return Ok(Rsp);
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("login")] 

        public async Task<IActionResult>Login([FromBody] LoginDtos login)
        {
            var Rsp = new Response<SesionDto>();

            try
            {
                var claveencriptada = _crypto.encriptarSHA256(login.Clave);
                var sesion = await _Usuarioservices.ValidarCredenciales(login.Correo, claveencriptada);

                if (sesion != null)
                {
                    var token = _crypto.generarJWt(sesion);
                    sesion.Token = token;
                    Rsp.status = true;
                    Rsp.value = sesion;
                }
                else
                {
                    throw new Exception("El usuario no existe o la clave es incorrecta ");
                }
            }
            catch (Exception ex)
            {
                Rsp.status = false;
                Rsp.msg = ex.Message;
            }

            return Ok(Rsp);
        }


        //[Authorize(Roles = "administrador")]
        [HttpGet]
        [Route("ListaUsuario")]

        public async Task<IActionResult> ListaUsuario()
        {
            var Rsp = new Response<List<UsuarioDto>>();
            try
            {
                Rsp.status = true;
                Rsp.value = await _Usuarioservices.Lista();

            }
            catch (Exception ex)
            {
                Rsp.status = false;
                Rsp.msg = ex.Message;

            }

            return Ok(Rsp);
        }


        [Authorize(Roles = "Administrador")]
        [HttpPut]
        [Route("EditarUsuario")]

        public async Task<IActionResult>EditarUsuario(UsuarioDto modelo)
        {

            var editarusuario = new Response<bool>();
            try
            {
                editarusuario.status = true;
                editarusuario.value = await _Usuarioservices.Editar(modelo);

            }
            catch (Exception ex)
            {
                editarusuario.status = false;
                editarusuario.msg = ex.Message;

            }

            return Ok(editarusuario);


        }


        [Authorize(Roles = "Administrador")]
        [HttpDelete]
        [Route("EliminarUsuario")]

        public async Task<IActionResult> EliminarUsuario(int id)
        {

            var eliminarUsuario = new Response<bool>();
            try
            {
                eliminarUsuario.status = true;
                eliminarUsuario.value = await _Usuarioservices.Eliminar(id);

            }
            catch (Exception ex)
            {
                eliminarUsuario.status = false;
                eliminarUsuario.msg = ex.Message;

            }

            return Ok(eliminarUsuario);

        }
    }
}
