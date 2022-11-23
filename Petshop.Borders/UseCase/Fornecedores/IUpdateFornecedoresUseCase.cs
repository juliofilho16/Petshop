
using Petshop.Borders.Dtos.Repositories.Fornecedores;
using Petshop.Borders.Dtos.UseCase.Common;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Fornecedores
{
    public interface IUpdateFornecedoresUseCase : IUseCase<UpdateRequestBase<UpdateFornecedorDto>, UseCaseResponse<int?>>
    {
    }
}
