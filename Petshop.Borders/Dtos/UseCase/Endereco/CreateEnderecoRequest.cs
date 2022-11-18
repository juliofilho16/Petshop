using Petshop.Borders.Dtos.Repositories.Endereco;
using Petshop.Entities.EntitiesContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Dtos.UseCase.Endereco
{
    public class CreateEnderecoRequest
    {
        public CreateEnderecoRequest(int idPessoa,CreateEnderecoDto createEnderecoDto)
        {
            IdPessoa= idPessoa;
            CreateEnderecoDto = createEnderecoDto;
        }
        public CreateEnderecoRequest()
        {
            CreateEnderecoDto= new CreateEnderecoDto();
        }

        public int IdPessoa { get; set; }
        public CreateEnderecoDto CreateEnderecoDto { get; set; }
    }
}
