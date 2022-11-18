
using Petshop.Borders.Dtos.Repositories.Pet;
using Petshop.Borders.Dtos.UseCase.Common;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Pet
{
    public interface IUpdatePetUseCase : IUseCase<UpdateRequestBase<UpdatePetDto>, UseCaseResponse<int?>>
    {
    }
}
