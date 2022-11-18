using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Categoria
{
    public interface IDeleteCategoriaUseCase : IUseCase<UseCaseRequest<int>, UseCaseResponse<int?>>
    {
    }
}
