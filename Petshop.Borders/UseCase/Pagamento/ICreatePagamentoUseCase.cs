using Petshop.Borders.Dtos.Repositories.Pagamento;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Pagamento
{
    public interface ICreatePagamentoUseCase : IUseCase<UseCaseRequest<CreatePagamentoDto>, UseCaseResponse<int>>
    {
    }
}
