using Petshop.Borders.Dtos.Repositories.Categoria;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Categoria
{
    public interface IGetCategoriaUseCase : IUseCase<UseCaseRequest<int>, UseCaseResponse<ReadCategoriaDto>>
    {
    }
}
