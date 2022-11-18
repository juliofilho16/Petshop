using Petshop.Borders.Dtos.Repositories.Categoria;
using Petshop.Borders.Shared;
using Petshop.Borders.Dtos.UseCase.Categoria;

namespace Petshop.Borders.UseCase.Categoria
{
    public interface IGetListCategoriasUseCase : IUseCase<GetListCategoriasRequest, UseCaseResponse<List<ReadCategoriaDto>>>
    {
    }
}
