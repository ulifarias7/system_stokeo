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
    public class ProductoController : ControllerBase
    {

        private readonly IProductoServices _productoservicio;

        public ProductoController(IProductoServices productoservicio)
        {
            _productoservicio = productoservicio;
        }

        [Authorize(Roles = "Administrador,Empleado,supervisor,cliente")]
        [HttpGet]
        [Route("ListaProducto")]

        public async Task<IActionResult> ListaProducto()
        {
            var Rsp = new Response<List<ProductoDto>>();
            try
            {
                Rsp.status = true;
                Rsp.value = await _productoservicio.Listaproducto();

            }
            catch (Exception ex)
            {
                Rsp.status = false;
                Rsp.msg = ex.Message;

            }

            return Ok(Rsp);
        }

        [Authorize(Roles = "Administrador,Empleado")]
        [HttpPost]
        [Route("CrearProducto")]

        public async Task<IActionResult> CrearProducto([FromBody] ProductoDto producto)
        {
            var Rsp = new Response<ProductoDto>();
            try
            {
                Rsp.status = true;
                Rsp.value = await _productoservicio.Crearproducto(producto);

            }
            catch (Exception ex)
            {
                Rsp.status = false;
                Rsp.msg = ex.Message;

            }

            return Ok(Rsp);
        }

        [Authorize(Roles = "Administrador,Empleado")]
        [HttpPut]
        [Route("EditarProducto")]

        public async Task<IActionResult> EditarProducto(ProductoDto Producto)
        {

            var editarProducto = new Response<bool>();
            try
            {
                editarProducto.status = true;
                editarProducto.value = await _productoservicio.Editarproducto(Producto);

            }
            catch (Exception ex)
            {
                editarProducto.status = false;
                editarProducto.msg = ex.Message;

            }

            return Ok(editarProducto);


        }

        [Authorize(Roles = "Administrador")]
        [HttpDelete]
        [Route("EliminarProducto")]

        public async Task<IActionResult> EliminarProducto(int id)
        {

            var eliminarUsuario = new Response<bool>();
            try
            {
                eliminarUsuario.status = true;
                eliminarUsuario.value = await _productoservicio.Eliminarproducto(id);

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
