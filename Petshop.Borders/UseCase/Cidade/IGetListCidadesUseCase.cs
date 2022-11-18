using Petshop.Borders.Dtos.Repositories.Cidade;
using Petshop.Borders.Shared;

namespace Petshop.Borders.UseCase.Cidade
{
    public interface IGetListCidadesUseCase : IUseCase<UseCaseRequest<int>, UseCaseResponse<List<ReadCidadeDto>>>
    {
    }
}
