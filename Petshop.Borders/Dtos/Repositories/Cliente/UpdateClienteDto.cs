using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Petshop.Borders.Dtos.Repositories.Pessoa;

namespace Petshop.Borders.Dtos.Repositories.Cliente
{
    public class UpdateClienteDto : UpdatePessoaDto
    {
        [Required]
        [StringLength(50)]
        public string Tipo { get; set; }
    }
}
