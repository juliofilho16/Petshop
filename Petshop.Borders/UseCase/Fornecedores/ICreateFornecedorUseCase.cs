using Petshop.Borders.Dtos.Repositories.Fornecedores;
using Petshop.Borders.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.UseCase.Fornecedores
{
    public interface ICreateFornecedorUseCase : IUseCase<UseCaseRequest<CreateFornecedorDto>, UseCaseResponse<int>>
    {
    }
}
