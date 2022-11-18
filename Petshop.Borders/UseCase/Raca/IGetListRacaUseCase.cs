using Petshop.Borders.Dtos.Repositories.Raca;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Raca
{
    public interface IGetListRacasUseCase : IUseCase<UseCaseRequest<int>, UseCaseResponse<List<ReadRacaDto>>>
    {
    }
}
