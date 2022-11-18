using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Dtos.Repositories.Endereco
{
    public class UpdateEnderecoDto
    {
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Campo Cidade deve ser preenchido")]
        public int IdCidade { get; set; }

        [Required]
        [StringLength(256)]
        public string Logradouro { get; set; }

        [Required]
        [StringLength(10)]
        public string Numero { get; set; }


        [StringLength(256)]
        public string Complemento { get; set; }

        [Required]
        [StringLength(256)]
        public string Bairro { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 8)]
        public string Cep { get; set; }
    }
}
