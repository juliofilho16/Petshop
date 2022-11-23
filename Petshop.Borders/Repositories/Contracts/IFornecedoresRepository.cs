using Petshop.Borders.Dtos.Repositories.Fornecedores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Repositories.Contracts
{
    public interface IFornecedoresRepository
    {
        List<ReadFornecedoresDto> GetListFornecedores();
        ReadFornecedoresDto GetFornecedor(int idFornecedor);
        int CreateFornecedor(CreateFornecedorDto createFornecedorDto);
        void UpdateFornecedor(int idFornecedor, UpdateFornecedorDto updateFornecedorDto);
        void DeleteFornecedor(int idFornecedor);
    }
}
