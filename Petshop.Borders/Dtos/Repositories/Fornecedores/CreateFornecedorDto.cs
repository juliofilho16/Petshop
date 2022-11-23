using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Petshop.Borders.Dtos.Repositories.Fornecedores
{
    public class CreateFornecedorDto
    {
        [Required]
        public string? NomeSocial { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Cnpj { get; set; }
        [Required]
        public string? Site { get; set; }
        [Required]
        public string? Telefone { get; set; }
        public string? RamoAtividade { get; set; }
        public string? Cep { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
    }
}
