using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Petshop.Borders.Dtos.Repositories.Pagamento;

namespace Petshop.Borders.Dtos.Repositories.Pagamento
{
    public class ReadPagamentoDto
    {
        [Key]
        public int Id { get; set; }
        public int IdServico { get; set; }
        public decimal Valor { get; set; }
        public int Situacao { get; set; }
    }
    public static class ReadPagamentoDtoConversions
    {
        public static ReadPagamentoDto toReadPagamentoDto(this Entities.EntitiesContext.Pagamento Pagamento)
        {
            ReadPagamentoDto PagamentoDto = new ReadPagamentoDto();
            PagamentoDto.Id = Pagamento.Id;
            PagamentoDto.IdServico = Pagamento.IdServico;
            PagamentoDto.Valor = Pagamento.Valor;
            PagamentoDto.Situacao = Pagamento.Situacao;

            return PagamentoDto;
        }
    }
}
