using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Dtos.UseCase.Categoria
{
    public class GetListCategoriasRequest
    {
        public GetListCategoriasRequest()
        {
        }

        public GetListCategoriasRequest(int idProduto)
        {
            IdProduto = idProduto;
        }

        public int IdProduto { get; set; }
    }
}
