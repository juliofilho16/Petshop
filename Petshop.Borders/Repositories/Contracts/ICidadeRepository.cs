using Petshop.Borders.Dtos.Repositories.Cidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Repositories.Contracts
{
    public interface ICidadeRepository
    {
        List<ReadCidadeDto> GetListCidades();
        ReadCidadeDto GetCidade(int idCidade);
        void CreateCidade(CreateCidadeDto createCidadeDto);
        void UpdateCidade(int idCidade, UpdateCidadeDto updateCidadeDto);
    }
}
