using Petshop.Borders.Dtos.Repositories.Pet;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Pet
{
    public interface IGetPetUseCase : IUseCase<UseCaseRequest<int>, UseCaseResponse<ReadPetDto>>
    {
    }
}
