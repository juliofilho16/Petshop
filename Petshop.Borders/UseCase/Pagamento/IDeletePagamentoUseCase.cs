using Petshop.Borders.Dtos.Repositories.Pagamento;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Pagamento
{
    public interface IDeletePagamentoUseCase : IUseCase<UseCaseRequest<int>, UseCaseResponse<int?>>
    {
    }
}
