using System;
using SistemaStokeo.MODELS;

namespace SistemaStokeo.DAL.Repositorios.Contratos
{
    public interface IVentaRepository : IGenericRepository<Venta>
    {
        Task<Venta> Registrar(Venta modelo); 
    }
}
