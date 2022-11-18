using Petshop.Borders.Dtos.Repositories.Cliente;
using Petshop.Borders.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.UseCase.Cliente
{
    public interface ICreateClienteUseCase : IUseCase<UseCaseRequest<CreateClienteDto>, UseCaseResponse<int>>
    {
    }
}
