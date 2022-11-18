using Petshop.Borders.Dtos.Repositories.Produto;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Produto
{
    public interface IGetProdutoUseCase : IUseCase<UseCaseRequest<int>, UseCaseResponse<ReadProdutoDto>>
    {
    }
}
