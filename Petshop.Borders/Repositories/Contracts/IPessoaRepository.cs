using Petshop.Borders.Dtos.Repositories.Pessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Repositories.Contracts
{
    public interface IPessoaRepository
    {
        List<ReadPessoaDto> GetListPessoas();
        ReadPessoaDto GetPessoa(int idPessoa);
        int CreatePessoa(CreatePessoaDto createPessoaDto);
        void UpdatePessoa(int idPessoa, UpdatePessoaDto updatePessoaDto);
    }
}
