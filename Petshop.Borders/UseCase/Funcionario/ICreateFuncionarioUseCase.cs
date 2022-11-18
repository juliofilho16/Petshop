using Petshop.Borders.Dtos.Repositories.Funcionario;
using Petshop.Borders.Shared;


namespace Petshop.Borders.UseCase.Funcionario
{
    public interface ICreateFuncionarioUseCase : IUseCase<UseCaseRequest<CreateFuncionarioDto>, UseCaseResponse<int>>
    {
    }
}
