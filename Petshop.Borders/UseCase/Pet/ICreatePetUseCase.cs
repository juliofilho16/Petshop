using Petshop.Borders.Dtos.Repositories.Pet;
using Petshop.Borders.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.UseCase.Pet
{
    public interface ICreatePetUseCase : IUseCase<UseCaseRequest<CreatePetDto>, UseCaseResponse<int>>
    {
    }
}
