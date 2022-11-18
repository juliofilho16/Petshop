using Petshop.Borders.Dtos.Repositories.Produto;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Produto
{
    public interface IDeleteProdutoUseCase : IUseCase<UseCaseRequest<int>, UseCaseResponse<int?>>
    {
    }
}
