using Petshop.Borders.Dtos.Repositories.Funcionario;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Funcionario
{
    public interface IGetFuncionarioUseCase : IUseCase<UseCaseRequest<int>, UseCaseResponse<ReadFuncionarioDto>>
    {
    }
}
