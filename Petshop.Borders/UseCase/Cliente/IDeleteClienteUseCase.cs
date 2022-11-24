using Petshop.Borders.Dtos.Repositories.Cliente;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Cliente
{
    public interface IDeleteClienteUseCase : IUseCase<UseCaseRequest<int>, UseCaseResponse<int?>>
    {
    }
}
