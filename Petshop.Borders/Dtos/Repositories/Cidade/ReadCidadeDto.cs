using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Petshop.Borders.Dtos.Repositories.Estado;

namespace Petshop.Borders.Dtos.Repositories.Cidade
{
    public class ReadCidadeDto
    {
        public ReadCidadeDto()
        {
            Estado = new ReadEstadoDto(); 
        }

        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public ReadEstadoDto Estado { get; set; }
    }
}
