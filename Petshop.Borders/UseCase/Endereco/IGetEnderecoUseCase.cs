using Petshop.Borders.Dtos.Repositories.Endereco;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Endereco
{
    public interface IGetEnderecoUseCase : IUseCase<UseCaseRequest<int>, UseCaseResponse<ReadEnderecoDto>>
    {
    }
}
