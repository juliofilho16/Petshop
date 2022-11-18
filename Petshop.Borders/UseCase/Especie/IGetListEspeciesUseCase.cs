using Petshop.Borders.Dtos.Repositories.Especie;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Especie
{
    public interface IGetListEspeciesUseCase : IUseCase<UseCaseRequest<int>, UseCaseResponse<List<ReadEspecieDto>>>
    {
    }
}
