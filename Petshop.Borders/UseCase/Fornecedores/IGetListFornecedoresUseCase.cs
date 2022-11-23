using Petshop.Borders.Dtos.Repositories.Fornecedores;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Fornecedores
{
    public interface IGetListFornecedoresUseCase : IUseCase<UseCaseRequest<int>, UseCaseResponse<List<ReadFornecedoresDto>>>
    {
    }
}
