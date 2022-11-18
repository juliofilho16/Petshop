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
    public class ReadCategoriaDto
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
