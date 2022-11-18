using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Dtos.Repositories.Pagamento
{
    public class CreatePagamentoDto
    {
        public int IdServico { get; set; }
        public decimal Valor { get; set; }
        public SituacaoPagamento SituacaoPagamento { get { return (SituacaoPagamento)this.Situacao; } set => this.Situacao = (int)value; }
        private int Situacao { get; set; }
        public int GetSituacao() => this.Situacao;
    }
}
