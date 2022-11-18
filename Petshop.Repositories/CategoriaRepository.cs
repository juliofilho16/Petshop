using AutoMapper;
using Petshop.Borders.Dtos.Repositories.Categoria;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Entities.EntitiesContext;
using Petshop.Repositories.ConfigBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Repositories
{
    public class CategoriaRepository : BaseRepository, ICategoriaRepository
    {
        private IMapper _mapper;
        public CategoriaRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public int CreateCategoria(CreateCategoriaDto createCategoriaDto)
        {
            Categoria categoria = _mapper.Map<Categoria>(createCategoriaDto);
            Create(categoria);
            return categoria.Id;
        }
        public ReadCategoriaDto GetCategoria(int idCategoria)
        {
            var entity = GetById<Categoria>(idCategoria);

            if (entity != null)
            {
                return _mapper.Map<ReadCategoriaDto>(entity); ;
            }

            return null!;
        }
        public List<ReadCategoriaDto> GetListCategorias()
        {
            var listEntitys = Contexto.Categoria.ToList();

            if (listEntitys != null)
            {
                return _mapper.Map<List<ReadCategoriaDto>>(listEntitys);
            }

            return null!;
        }
        public List<ReadCategoriaDto> GetCategoriasProduto(int IdProduto)
        {
            var listEntitys = Contexto.Categoria.Where(a => a.Produto.Where(b => b.Id == IdProduto).Count() > 0).ToList();

            if (listEntitys != null)
            {
                return _mapper.Map<List<ReadCategoriaDto>>(listEntitys);
            }

            return null!;
        }
        public void UpdateCategoria(int idCategoria, UpdateCategoriaDto updateCategoriaDto)
        {
            Categoria? entity = GetById<Categoria>(idCategoria);

            if (entity == null)
            {
                throw new Exception("Categoria não encontrada");
            }
            entity!.Nome = updateCategoriaDto.Nome;
            Edit(entity);
        }
        public void DeleteCategoria(int idCategoria)
        {
            Categoria? entity = GetById<Categoria>(idCategoria);

            if (entity == null)
            {
                throw new Exception("Categoria não encontrado");
            }

            Delete(entity!);
        }
    }
}