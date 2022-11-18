using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Dtos.Repositories.Especie
{
    public class CreateEspecieDto
    {
        [Required]
        [StringLength(256)]
        public string Descricao { get; set; }
    }
}
