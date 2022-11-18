using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Petshop.Borders.Dtos.Repositories.Pagamento;
using Petshop.Borders.Dtos.Repositories.Pagamento;
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
    public class PagamentoRepository : BaseRepository, IPagamentoRepository
    {
        private IMapper _mapper;
        public PagamentoRepository(IMapper mapper)
        {
            _mapper = mapper;
        }
        public List<ReadPagamentoDto> GetPagamentos(int IdServico)
        {
            var listEntitys = Contexto.Pagamento.Where(a => a.IdServico == IdServico).ToList();

            if (listEntitys != null)
            {
                return listEntitys.Select(a => a.toReadPagamentoDto()).ToList();
            }

            return null!;
        }
        private Pagamento? _GetEntityById(int id)
        {
            return Contexto.Pagamento.Where(a => a.Id == id)
                                    .FirstOrDefault();
        }
        public int CreatePagamento(CreatePagamentoDto createPagamentoDto)
        {
            Pagamento Pagamento = _mapper.Map<Pagamento>(createPagamentoDto);
            Create(Pagamento);
            return Pagamento.Id;
        }
        public ReadPagamentoDto GetPagamento(int idPagamento)
        {
            var entity = _GetEntityById(idPagamento);
            if (entity != null)
            {
                return entity.toReadPagamentoDto();
            }

            return null!;
        }
        public void UpdatePagamento(int idPagamento, UpdatePagamentoDto updatePagamentoDto)
        {
            Pagamento? entity = GetById<Pagamento>(idPagamento);

            if (entity == null)
            {
                throw new Exception("Pagamento não encontrado");
            }
            entity!.Situacao = updatePagamentoDto.GetSituacao();
            entity!.Valor = updatePagamentoDto.Valor;
            Edit(entity);
        }
        public void DeletePagamento(int idPagamento)
        {
            Pagamento? entity = GetById<Pagamento>(idPagamento);

            if (entity == null)
            {
                throw new Exception("Pagamento não encontrado");
            }

            Delete(entity!);
        }
    }
}