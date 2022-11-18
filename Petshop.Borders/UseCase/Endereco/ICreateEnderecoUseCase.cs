using Petshop.Borders.Dtos.Repositories.Endereco;
using Petshop.Borders.Dtos.UseCase.Endereco;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Endereco
{
    public interface ICreateEnderecoUseCase : IUseCase<CreateEnderecoRequest, UseCaseResponse<int>>
    {
    }
}
