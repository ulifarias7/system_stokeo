﻿using AutoMapper;
using SistemaStokeo.BLL.Servicios.Contrato;
using SistemaStokeo.DAL.Repositorios.Contratos;
using SistemStokeo.DTO;
using SistemaStokeo.MODELS;


namespace SistemaStokeo.BLL.Servicios
{
    public class CategoriaServices : ICategoriaServices
    {
        private readonly IGenericRepository<Categoria> _Categoriarepositorio;
        private readonly IMapper _mapper;

        public CategoriaServices(IGenericRepository<Categoria> rOLrepositorio,
            IMapper mapper)
        {
            _Categoriarepositorio = rOLrepositorio;
            _mapper = mapper;
        }

        public async  Task<CategoriaDto> CrearCategoria(CategoriaDto categoria)
        {
            try
            {
                var categoriacreada = await _Categoriarepositorio.Crear(_mapper.Map<Categoria>(categoria));
                if (categoriacreada.IdCategoria == 0)
                    throw new TaskCanceledException(" no pudo ser creado");
             
                return _mapper.Map<CategoriaDto>(categoriacreada);
            }
            catch
            {
                throw;
            }
        }

        public async Task<List<CategoriaDto>> ListCategoria() 
        {
            var Listacategorias = await _Categoriarepositorio.Consultar();
            if (Listacategorias is null)
            {
                throw new TaskCanceledException("no trajo resultados el repo");
            }
            return _mapper.Map<List<CategoriaDto>>(Listacategorias.ToList());
        }
    }
}
