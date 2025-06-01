using System;
using SistemStokeo.DTO;

namespace SistemaStokeo.BLL.Servicios.Contrato
{
    public interface IRolServices
    {
        Task<List<RolDto>> List();
    }
}
