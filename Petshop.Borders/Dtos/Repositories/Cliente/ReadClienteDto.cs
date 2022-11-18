using Microsoft.EntityFrameworkCore;
using Petshop.Borders.Dtos.Repositories.Pessoa;
using Petshop.Entities.EntitiesContext;

namespace Petshop.Borders.Dtos.Repositories.Cliente
{
    public class ReadClienteDto : ReadPessoaDto
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
    }

    public static class ReadClienteDtoConversions
    {
        public static ReadClienteDto toReadClienteDto(this Entities.EntitiesContext.Cliente cliente)
        {
            ReadClienteDto clienteDto = new ReadClienteDto();
            clienteDto.Id = cliente.Id;
            clienteDto.Tipo = cliente.Tipo;
            clienteDto.IdPessoa = cliente.IdPessoaNavigation.Id;
            clienteDto.Nome = cliente.IdPessoaNavigation.Nome;
            clienteDto.Email = cliente.IdPessoaNavigation.Email;
            clienteDto.Telefone = cliente.IdPessoaNavigation.Telefone;
            clienteDto.CodNac = cliente.IdPessoaNavigation.CodNac;

            return clienteDto;
        }
    }
}
