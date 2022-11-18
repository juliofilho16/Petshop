using Petshop.Borders.Dtos.Repositories.Servico;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Servico
{
    public interface IDeleteServicoUseCase : IUseCase<UseCaseRequest<int>, UseCaseResponse<int?>>
    {
    }
}
