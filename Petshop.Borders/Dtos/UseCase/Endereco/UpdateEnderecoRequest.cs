using Petshop.Borders.Dtos.Repositories.Endereco;
using Petshop.Entities.EntitiesContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Dtos.UseCase.Endereco
{
    public class UpdateEnderecoRequest
    {
        public UpdateEnderecoRequest(int id, UpdateEnderecoDto updateEnderecoDto)
        {
            Id = id;
            UpdateEnderecoDto = updateEnderecoDto;
        }
        public UpdateEnderecoRequest()
        {
            UpdateEnderecoDto = new UpdateEnderecoDto();
        }

        public int Id { get; set; }
        public UpdateEnderecoDto UpdateEnderecoDto { get; set; }
    }
}
