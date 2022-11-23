using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Petshop.Borders.Dtos.Repositories.Cliente;
using Petshop.Borders.Dtos.Repositories.Funcionario;
using Petshop.Borders.Dtos.Repositories.Pet;
using Petshop.Borders.Dtos.Repositories.Produto;
using Petshop.Borders.Dtos.Repositories.Fornecedores;
using System.Runtime.ConstrainedExecution;
#nullable disable

namespace Petshop.Borders.Dtos.Repositories.Fornecedores
{
    public class ReadFornecedoresDto
    {
        [Key]
        public int Id { get; set; }
        public string NomeSocial { get; set; }
        public string Email { get; set; }
        public string Cnpj { get; set; }
        public string Site { get; set; }
        public string Telefone { get; set; }
        public string RamoAtividade { get; set; }
        public string Cep { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
    }

    public static class ReadFornecedoresDtoConversions
    {
        public static ReadFornecedoresDto toReadFornecedoresDto(this Entities.EntitiesContext.Fornecedores Fornecedores)
        {
            ReadFornecedoresDto FornecedoresDto = new ReadFornecedoresDto();

            FornecedoresDto.Id = Fornecedores.Id;
            FornecedoresDto.NomeSocial = Fornecedores.NomeSocial;
            FornecedoresDto.Email = Fornecedores.Email;
            FornecedoresDto.Cnpj = Fornecedores.Cnpj;
            FornecedoresDto.Site = Fornecedores.Site;
            FornecedoresDto.Telefone = Fornecedores.Telefone;
            FornecedoresDto.RamoAtividade = Fornecedores.RamoAtividade;
            FornecedoresDto.Cep = Fornecedores.Cep;
            FornecedoresDto.Numero = Fornecedores.Numero;
            FornecedoresDto.Complemento = Fornecedores.Complemento;

            return FornecedoresDto;
        }

        public static void fromUpdateFornecedoresDto(this Entities.EntitiesContext.Fornecedores Fornecedores, UpdateFornecedorDto FornecedoresDto)
        {
            Fornecedores.NomeSocial = FornecedoresDto.NomeSocial;
            Fornecedores.Email = FornecedoresDto.Email;
            Fornecedores.Cnpj = FornecedoresDto.Cnpj;
            Fornecedores.Site = FornecedoresDto.Site;
            Fornecedores.Telefone = FornecedoresDto.Telefone;
            Fornecedores.RamoAtividade = FornecedoresDto.RamoAtividade;
            Fornecedores.Cep = FornecedoresDto.Cep;
            Fornecedores.Numero = FornecedoresDto.Numero;
            Fornecedores.Complemento = FornecedoresDto.Complemento;
        }
    }
}
