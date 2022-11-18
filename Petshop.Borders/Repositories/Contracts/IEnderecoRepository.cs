using Petshop.Borders.Dtos.Repositories.Endereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Repositories.Contracts
{
    public interface IEnderecoRepository
    {
        List<ReadEnderecoDto> GetListEnderecos(int idPessoa);
        ReadEnderecoDto GetEndereco(int idEndereco);
        int CreateEndereco(int idPessoa, CreateEnderecoDto createEnderecoDto);
        void UpdateEndereco(int idEndereco, UpdateEnderecoDto updateEnderecoDto);
        void DeleteEndereco(int idEndereco);

    }
}
