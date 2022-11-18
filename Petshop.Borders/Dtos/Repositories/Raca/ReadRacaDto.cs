using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Dtos.Repositories.Raca
{
    public class ReadRacaDto
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}
