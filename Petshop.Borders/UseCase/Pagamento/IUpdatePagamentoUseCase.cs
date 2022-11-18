
using Petshop.Borders.Dtos.Repositories.Pagamento;
using Petshop.Borders.Dtos.UseCase.Common;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Pagamento
{
    public interface IUpdatePagamentoUseCase : IUseCase<UpdateRequestBase<UpdatePagamentoDto>, UseCaseResponse<int?>>
    {
    }
}
