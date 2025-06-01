using SistemStokeo.DTO;

namespace SistemaStokeo.BLL.Servicios.Contrato
{
    public interface IMenuServices
    {
        Task<List<MenuDto>> Lista(int IdUsuario);
    }
}
