using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Dtos.Repositories.Pet
{
    public class CreatePetDto
    {
        [Required]
        [StringLength(256)]
        public string Nome { get; set; }
        public int IdEspecie { get; set; }
        public int IdRaca { get; set; }
        public int Idade { get; set; }
    }
}
