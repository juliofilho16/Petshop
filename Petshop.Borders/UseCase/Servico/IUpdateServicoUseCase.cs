
using Petshop.Borders.Dtos.Repositories.Servico;
using Petshop.Borders.Dtos.UseCase.Common;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Servico
{
    public interface IUpdateServicoUseCase : IUseCase<UpdateRequestBase<UpdateServicoDto>, UseCaseResponse<int?>>
    {
    }
}
