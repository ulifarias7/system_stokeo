using SistemStokeo.DTO;

namespace SistemaStokeo.BLL.Servicios.Contrato
{
    public interface ICategoriaServices
    {
        Task<List<CategoriaDto>> ListCategoria();
        Task<CategoriaDto> CrearCategoria(CategoriaDto categoria);
    }
}
