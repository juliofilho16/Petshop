
using Petshop.Borders.Dtos.Repositories.Produto;
using Petshop.Borders.Dtos.UseCase.Common;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Produto
{
    public interface IUpdateProdutoUseCase : IUseCase<UpdateRequestBase<UpdateProdutoDto>, UseCaseResponse<int?>>
    {
    }
}
