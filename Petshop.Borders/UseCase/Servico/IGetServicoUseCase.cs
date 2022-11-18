using Petshop.Borders.Dtos.Repositories.Servico;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Servico
{
    public interface IGetServicoUseCase : IUseCase<UseCaseRequest<int>, UseCaseResponse<ReadServicoDto>>
    {
    }
}
