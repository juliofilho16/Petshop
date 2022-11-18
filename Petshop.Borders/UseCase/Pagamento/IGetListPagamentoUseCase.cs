using Petshop.Borders.Dtos.Repositories.Pagamento;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Pagamento
{
    public interface IGetListPagamentosUseCase : IUseCase<UseCaseRequest<int>, UseCaseResponse<List<ReadPagamentoDto>>>
    {
    }
}
