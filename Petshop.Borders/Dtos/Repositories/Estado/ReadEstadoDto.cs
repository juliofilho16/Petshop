using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Dtos.Repositories.Estado
{
    public class ReadEstadoDto
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }
    }
}
