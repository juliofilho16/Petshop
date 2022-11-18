using Petshop.Borders.Dtos.Repositories.Servico;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Servico
{
    public interface IGetListServicosUseCase : IUseCase<UseCaseRequest<int>, UseCaseResponse<List<ReadServicoDto>>>
    {
    }
}
