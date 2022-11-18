using Petshop.Borders.Dtos.Repositories.Pessoa;
using System.ComponentModel.DataAnnotations;

namespace Petshop.Borders.Dtos.Repositories.Funcionario
{
    public class CreateFuncionarioDto : CreatePessoaDto
    {
        [Required]
        [StringLength(256)]
        public string Funcao { get; set; }
    }
}
