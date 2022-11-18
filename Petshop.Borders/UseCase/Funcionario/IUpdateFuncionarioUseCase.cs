
using Petshop.Borders.Dtos.Repositories.Funcionario;
using Petshop.Borders.Dtos.UseCase.Common;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Funcionario
{
    public interface IUpdateFuncionarioUseCase : IUseCase<UpdateRequestBase<UpdateFuncionarioDto>, UseCaseResponse<int?>>
    {
    }
}
