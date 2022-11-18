using Petshop.Borders.Dtos.Repositories.Servico;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Servico
{
    public interface ICreateServicoUseCase : IUseCase<UseCaseRequest<CreateServicoDto>, UseCaseResponse<int>>
    {
    }
}
