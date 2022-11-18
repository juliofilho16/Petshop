using Petshop.Borders.Dtos.Repositories.Endereco;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Endereco
{
    public interface IDeleteEnderecoUseCase : IUseCase<UseCaseRequest<int>, UseCaseResponse<int?>>
    {
    }
}
