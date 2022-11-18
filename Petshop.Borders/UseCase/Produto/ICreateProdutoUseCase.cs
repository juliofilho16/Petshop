using Petshop.Borders.Dtos.Repositories.Produto;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Produto
{
    public interface ICreateProdutoUseCase : IUseCase<UseCaseRequest<CreateProdutoDto>, UseCaseResponse<int>>
    {
    }
}
