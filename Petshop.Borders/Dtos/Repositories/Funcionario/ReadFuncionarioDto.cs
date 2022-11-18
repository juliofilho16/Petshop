using System.ComponentModel.DataAnnotations;
using Petshop.Borders.Dtos.Repositories.Funcionario;
using Petshop.Borders.Dtos.Repositories.Pessoa;

namespace Petshop.Borders.Dtos.Repositories.Funcionario
{
    public class ReadFuncionarioDto : ReadPessoaDto
    {
        public int Id { get; set; }
        public string Funcao { get; set; }
    }
    public static class ReadFuncionarioDtoConversions
    {
        public static ReadFuncionarioDto toReadFuncionarioDto(this Entities.EntitiesContext.Funcionario Funcionario)
        {
            ReadFuncionarioDto FuncionarioDto = new ReadFuncionarioDto();
            FuncionarioDto.Id = Funcionario.Id;
            FuncionarioDto.Funcao = Funcionario.Funcao;
            FuncionarioDto.IdPessoa = Funcionario.IdPessoaNavigation.Id;
            FuncionarioDto.Nome = Funcionario.IdPessoaNavigation.Nome;
            FuncionarioDto.Email = Funcionario.IdPessoaNavigation.Email;
            FuncionarioDto.Telefone = Funcionario.IdPessoaNavigation.Telefone;
            FuncionarioDto.CodNac = Funcionario.IdPessoaNavigation.CodNac;

            return FuncionarioDto;
        }
    }
}
