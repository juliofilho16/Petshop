using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Petshop.Borders.Dtos.Repositories.Categoria
{
    public class CreateCategoriaDto
    {
        [Required]
        [Column("nome")]
        [StringLength(256)]
        public string Nome { get; set; }
    }
}
