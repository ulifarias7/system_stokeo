using SistemStokeo.DTO;

namespace SistemaStokeo.BLL.Servicios.Contrato
{
    public interface IProductoServices
    {
        Task<List<ProductoDto>> Listaproducto();
        Task<ProductoDto> Crearproducto(ProductoDto modelo);
        Task<bool> Editarproducto(ProductoDto modelo);
        Task<bool> Eliminarproducto(int id);  
    }
}
