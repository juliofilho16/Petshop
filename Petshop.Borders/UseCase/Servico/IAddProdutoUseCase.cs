using Petshop.Borders.Dtos.Repositories.Servico;
using Petshop.Borders.Dtos.UseCase.Servico;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Servico
{
    public interface IAddProdutoUseCase : IUseCase<UseCaseRequest<AddProdutoRequest>, UseCaseResponse<int?>>
    {
    }
}
