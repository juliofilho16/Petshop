
using Petshop.Borders.Dtos.Repositories.Cliente;
using Petshop.Borders.Dtos.UseCase.Common;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Cliente
{
    public interface IUpdateClienteUseCase : IUseCase<UpdateRequestBase<UpdateClienteDto>, UseCaseResponse<int?>>
    {
    }
}
