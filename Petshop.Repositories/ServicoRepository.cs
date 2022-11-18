using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Petshop.Borders.Dtos.Repositories.Servico;
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
    public class ServicoRepository : BaseRepository, IServicoRepository
    {
        private IMapper _mapper;
        private readonly IPagamentoRepository _pagamentoRepository;
        private readonly IProdutoRepository _produtoRepository;
        public ServicoRepository(IMapper mapper, IPagamentoRepository pagamentoRepository, IProdutoRepository produtoRepository)
        {
            _mapper = mapper;
            _pagamentoRepository = pagamentoRepository;
            _produtoRepository = produtoRepository;
        }

        private Servico? _GetEntityById(int id)
        {
            return Contexto.Servico.Where(a => a.Id == id)
                                    .Include(b => b.IdClienteNavigation.IdPessoaNavigation)
                                    .Include(b => b.IdFuncionarioNavigation.IdPessoaNavigation)
                                    .Include(b => b.IdPetNavigation).ThenInclude(b => b.IdRacaNavigation)
                                    .Include(b => b.IdPetNavigation).ThenInclude(b => b.IdEspecieNavigation)
                                    .FirstOrDefault();
        }
        public int CreateServico(CreateServicoDto createServicoDto)
        {
            Servico Servico = createServicoDto.toCreateServicoDto();
            Create(Servico);
            return Servico.Id;
        }
        public ReadServicoDto GetServico(int idServico)
        {
            var entity = _GetEntityById(idServico);
            if (entity != null)
            {
                var model = entity.toReadServicoDto();
                //model.Pagamentos = _pagamentoRepository.GetPagamentos(idServico);
                //model.Produtos = _produtoRepository.GetListProdutosByServico(idServico);
                return model;
            }

            return null!;
        }
        public List<ReadServicoDto> GetListServicos()
        {
            var listEntitys = Contexto.Servico
                                    .Include(b => b.IdClienteNavigation.IdPessoaNavigation)
                                    .Include(b => b.IdFuncionarioNavigation.IdPessoaNavigation)
                                    .Include(b => b.IdPetNavigation).ThenInclude(b => b.IdRacaNavigation)
                                    .Include(b => b.IdPetNavigation).ThenInclude(b => b.IdEspecieNavigation)
                                    .ToList();

            if (listEntitys != null)
            {
                return listEntitys.Select(a => a.toReadServicoDto()).ToList();
            }

            return null!;
        }
        public void UpdateServico(int idServico, UpdateServicoDto updateServicoDto)
        {
            Servico? entity = GetById<Servico>(idServico);

            if (entity == null)
            {
                throw new Exception("Servico não encontrado");
            }
            entity.fromUpdateServicoDto(updateServicoDto);
            Edit(entity);
        }
        public void DeleteServico(int idServico)
        {
            Servico? entity = GetById<Servico>(idServico);

            if (entity == null)
            {
                throw new Exception("Servico não encontrado");
            }

            Delete(entity!);
        }
        public void AddProduto(int idServico, int idProduto)
        {
            Servico? entity = GetById<Servico>(idServico);

            if (entity == null)
            {
                throw new Exception("Servico não encontrado");
            }

            Create(new ServicoProduto() { IdProduto = idProduto, IdServico = idServico });
        }
    }
}