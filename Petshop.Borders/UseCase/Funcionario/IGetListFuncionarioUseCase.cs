using Petshop.Borders.Dtos.Repositories.Funcionario;
using Petshop.Borders.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.UseCase.Funcionario
{
    public interface IGetListFuncionariosUseCase : IUseCase<UseCaseRequest<int>, UseCaseResponse<List<ReadFuncionarioDto>>>
    {
    }
}
