using Petshop.Borders.Dtos.Repositories.Categoria;
using Petshop.Borders.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.UseCase.Categoria
{
    public interface ICreateCategoriaUseCase : IUseCase<UseCaseRequest<CreateCategoriaDto>, UseCaseResponse<int>>
    {
    }
}
