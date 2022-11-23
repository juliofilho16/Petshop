using Petshop.Borders.Dtos.Repositories.Fornecedores;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Fornecedores
{
    public interface IGetFornecedorUseCase : IUseCase<UseCaseRequest<int>, UseCaseResponse<ReadFornecedoresDto>>
    {
    }
}
