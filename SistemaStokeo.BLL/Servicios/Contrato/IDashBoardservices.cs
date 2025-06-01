using SistemStokeo.DTO;

namespace SistemaStokeo.BLL.Servicios.Contrato
{
    public interface IDashBoardservices
    {
        Task<DashBoardDto> Resumen();
    }
}
