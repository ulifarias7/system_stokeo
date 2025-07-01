using AutoMapper;
using AutoMapper.QueryableExtensions;
using SistemaStokeo.DAL.DBContext;
using SistemaStokeo.DAL.Repositorios.Contratos;

namespace SistemaStokeo.DAL.Repositorios
{
    public class RolRepository : IRolRepository
    {
        private readonly DbsystemSContext _dbsystemSContext;
        private readonly IConfigurationProvider _configurationProvider;

        public RolRepository(DbsystemSContext dbsystemSContext,
            IConfigurationProvider configurationProvider)
        {
            _dbsystemSContext = dbsystemSContext;
            _configurationProvider = configurationProvider;
        }

        //se usa para hacer la consulta a la base de datos y q la consulta ya venga mapeada

        //public async Task<List<RolDto>> FindAll()
        //{
        //    return await _dbsystemSContext.Rols
        //         .ProjectTo<List<RolDto>>(_configurationProvider)
        //         .ToListAsync();
        //}
    }
}
