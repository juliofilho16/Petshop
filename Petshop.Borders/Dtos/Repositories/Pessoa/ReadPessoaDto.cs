using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Dtos.Repositories.Pessoa
{
    public class ReadPessoaDto
    {
        [Key]
        public int IdPessoa { get; set; }

        [Required]
        [StringLength(256)]
        public string Nome { get; set; }

        [Required]
        [StringLength(256)]
        public string Email { get; set; }

        [Required]
        [StringLength(256)]
        public string CodNac { get; set; }

        [Required]
        [StringLength(14)]
        public string Telefone { get; set; }
    }
}
