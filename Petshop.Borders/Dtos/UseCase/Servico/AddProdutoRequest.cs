using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Dtos.UseCase.Servico
{
    public class AddProdutoRequest
    {
        public AddProdutoRequest() { }

        public AddProdutoRequest(int idServico, int idProduto)
        {
            IdServico = idServico;
            IdProduto = idProduto;
        }

        public int IdServico { get; set; }
        public int IdProduto { get; set; }
    }
}
