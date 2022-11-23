using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Dtos.Repositories.Fornecedores
{
    public class UpdateFornecedorDto
    {
        [Required]
        [StringLength(256)]
        public string? NomeSocial { get; set; }
        [Required]
        [StringLength(256)]
        public string? Email { get; set; }
        [Required]
        [StringLength(14)]
        public string? Cnpj { get; set; }
        [Required]
        [StringLength(256)]
        public string? Site { get; set; }
        [Required]
        public string? Telefone { get; set; }
        public string? RamoAtividade { get; set; }
        public string? Cep { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
    }
}
