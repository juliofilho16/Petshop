using Petshop.Borders.Dtos.Repositories.Cliente;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Cliente
{
    public interface IGetClienteUseCase : IUseCase<UseCaseRequest<int>, UseCaseResponse<ReadClienteDto>>
    {
    }
}
