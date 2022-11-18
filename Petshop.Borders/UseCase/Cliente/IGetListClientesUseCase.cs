using Petshop.Borders.Dtos.Repositories.Cliente;
using Petshop.Borders.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.UseCase.Cliente
{
    public interface IGetListClientesUseCase : IUseCase<UseCaseRequest<int>, UseCaseResponse<List<ReadClienteDto>>>
    {
    }
}
