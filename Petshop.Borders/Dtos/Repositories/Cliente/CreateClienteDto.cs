using Microsoft.EntityFrameworkCore;
using Petshop.Borders.Dtos.Repositories.Pessoa;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Dtos.Repositories.Cliente
{
    public class CreateClienteDto : CreatePessoaDto
    {
        [Required]
        [StringLength(50)]
        public string Tipo { get; set; }
    }
}
