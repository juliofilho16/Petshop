using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Petshop.Borders.Dtos.Repositories.Produto;
using Petshop.Borders.Dtos.Repositories.Produto;
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
    public class ProdutoRepository : BaseRepository, IProdutoRepository
    {
        private IMapper _mapper;
        public ProdutoRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        private Produto? _GetEntityById(int id)
        {
            return Contexto.Produto.Where(a => a.Id == id)
                                    .Include(b => b.IdCategoriaNavigation)
                                    .FirstOrDefault();
        }
        public int CreateProduto(CreateProdutoDto createProdutoDto)
        {
            Produto Produto = _mapper.Map<Produto>(createProdutoDto);
            Create(Produto);
            return Produto.Id;
        }
        public ReadProdutoDto GetProduto(int idProduto)
        {
            var entity = _GetEntityById(idProduto);
            if (entity != null)
            {
                return entity.toReadProdutoDto();
            }

            return null!;
        }
        public List<ReadProdutoDto> GetListProdutos()
        {
            var listEntitys = Contexto.Produto
                                    .Include(b => b.IdCategoriaNavigation)
                                    .ToList();

            if (listEntitys != null)
            {
                return listEntitys.Select(a => a.toReadProdutoDto()).ToList();
            }

            return null!;
        }
        public void UpdateProduto(int idProduto, UpdateProdutoDto updateProdutoDto)
        {
            Produto? entity = GetById<Produto>(idProduto);

            if (entity == null)
            {
                throw new Exception("Produto não encontrado");
            }
            entity!.Nome = updateProdutoDto.Nome;
            entity!.Preco = updateProdutoDto.Preco;
            Edit(entity);
        }
        public void DeleteProduto(int idProduto)
        {
            Produto? entity = GetById<Produto>(idProduto);

            if (entity == null)
            {
                throw new Exception("Produto não encontrado");
            }

            Delete(entity!);
        }
        public List<ReadProdutoDto> GetListProdutosByServico(int IdServico)
        {
           return Contexto.ServicoProduto.Where(a => a.IdServico == IdServico)
                                   .Include(b => b.IdProdutoNavigation).ThenInclude(a=>a.IdCategoriaNavigation)
                                   .Select(a => a.IdProdutoNavigation.toReadProdutoDto())
                                   .ToList();

        }
    }
}