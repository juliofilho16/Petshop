using Petshop.Borders.Dtos.Repositories.Pessoa;
using System.ComponentModel.DataAnnotations;

namespace Petshop.Borders.Dtos.Repositories.Funcionario
{
    public class UpdateFuncionarioDto : UpdatePessoaDto
    {
        [Required]
        [StringLength(256)]
        public string Funcao { get; set; }
    }
}
