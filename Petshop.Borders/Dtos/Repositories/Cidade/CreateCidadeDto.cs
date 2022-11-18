using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Dtos.Repositories.Cidade
{
    public class CreateCidadeDto
    {
        public int Id { get; set; }
        public int IdEstado { get; set; }
        public string Nome { get; set; }
    }
}
