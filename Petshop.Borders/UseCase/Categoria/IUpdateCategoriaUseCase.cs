
using Petshop.Borders.Dtos.Repositories.Categoria;
using Petshop.Borders.Dtos.UseCase.Common;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Categoria
{
    public interface IUpdateCategoriaUseCase : IUseCase<UpdateRequestBase<UpdateCategoriaDto>, UseCaseResponse<int?>>
    {
    }
}
