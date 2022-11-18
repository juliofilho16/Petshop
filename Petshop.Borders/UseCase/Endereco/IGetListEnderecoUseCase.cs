using Petshop.Borders.Dtos.Repositories.Endereco;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Endereco
{
    public interface IGetListEnderecosUseCase : IUseCase<UseCaseRequest<int>, UseCaseResponse<List<ReadEnderecoDto>>>
    {
    }
}
