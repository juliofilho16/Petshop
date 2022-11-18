using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Dtos.Repositories.Produto
{
    public class UpdateProdutoDto
    {
        [Required]
        [StringLength(256)]
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}
