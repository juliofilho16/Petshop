using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Petshop.Borders.Dtos.Repositories.Cidade;
using Petshop.Borders.Dtos.Repositories.Endereco;
using Petshop.Entities.EntitiesContext;
using System.Runtime.ConstrainedExecution;

namespace Petshop.Borders.Dtos.Repositories.Endereco
{
    public class ReadEnderecoDto
    {
        public ReadEnderecoDto()
        {
            this.Cidade = new ReadCidadeDto();
        }

        [Key]
        public int Id { get; set; }
        public int IdPessoa { get; set; }
        public ReadCidadeDto Cidade { get; set; }

        [Required]
        [StringLength(256)]
        public string Logradouro { get; set; }

        [Required]
        [StringLength(10)]
        public string Numero { get; set; }

        [Required]
        [StringLength(256)]
        public string Complemento { get; set; }

        [Required]
        [StringLength(256)]
        public string Bairro { get; set; }

        [Required]
        [StringLength(8)]
        public string Cep { get; set; }
    }
    public static class ReadEnderecoDtoConversions
    {
        public static ReadEnderecoDto toReadEnderecoDto(this Entities.EntitiesContext.Endereco Endereco)
        {
            ReadEnderecoDto EnderecoDto = new ReadEnderecoDto();
            EnderecoDto.Id = Endereco.Id;

            EnderecoDto.Id = Endereco.Id;
            EnderecoDto.IdPessoa = Endereco.IdPessoa;
            EnderecoDto.Logradouro = Endereco.Logradouro;
            EnderecoDto.Numero = Endereco.Numero;
            EnderecoDto.Complemento = Endereco.Complemento;
            EnderecoDto.Bairro = Endereco.Bairro;
            EnderecoDto.Cep = Endereco.Cep;
            EnderecoDto.Cidade.Id = Endereco.IdCidadeNavigation.Id;
            EnderecoDto.Cidade.Nome = Endereco.IdCidadeNavigation.Nome;
            EnderecoDto.Cidade.Estado.Id = Endereco.IdCidadeNavigation.IdEstadoNavigation.Id;
            EnderecoDto.Cidade.Estado.Nome = Endereco.IdCidadeNavigation.IdEstadoNavigation.Nome;


            return EnderecoDto;
        }
    }
}
