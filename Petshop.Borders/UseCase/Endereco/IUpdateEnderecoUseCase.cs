
using Petshop.Borders.Dtos.UseCase.Endereco;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Endereco
{
    public interface IUpdateEnderecoUseCase : IUseCase<UpdateEnderecoRequest, UseCaseResponse<int?>>
    {
    }
}
