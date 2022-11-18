using Petshop.Borders.Dtos.Repositories.Produto;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Produto
{
    public interface IGetListProdutosUseCase : IUseCase<UseCaseRequest<int>, UseCaseResponse<List<ReadProdutoDto>>>
    {
    }
}
