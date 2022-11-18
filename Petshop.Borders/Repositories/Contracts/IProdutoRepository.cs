using Petshop.Borders.Dtos.Repositories.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Repositories.Contracts
{
    public interface IProdutoRepository
    {
        List<ReadProdutoDto> GetListProdutos();
        List<ReadProdutoDto> GetListProdutosByServico(int IdServico);
        ReadProdutoDto GetProduto(int idProduto);
        int CreateProduto(CreateProdutoDto createProdutoDto);
        void UpdateProduto(int idProduto, UpdateProdutoDto updateProdutoDto);
        void DeleteProduto(int idProduto);
    }
}
