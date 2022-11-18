using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Petshop.Borders.Dtos.Repositories.Servico;
using Petshop.Borders.Dtos.Repositories.Produto;
using Petshop.Borders.Dtos.Repositories.Cliente;
using Petshop.Borders.Dtos.Repositories.Funcionario;
using Petshop.Borders.Dtos.Repositories.Pet;
using Petshop.Entities.EntitiesContext;
using System.Globalization;
using Petshop.Borders.Dtos.Repositories.Pagamento;

namespace Petshop.Borders.Dtos.Repositories.Servico
{
    public class ReadServicoDto
    {
        public ReadServicoDto()
        {
            Cliente = new ReadClienteDto();
            Funcionario = new ReadFuncionarioDto();
            Pet = new ReadPetDto();
            Produtos = new List<ReadProdutoDto>();
        }

        [Key]
        public int Id { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime? DataSaida { get; set; }
        public string? Descricao { get; set; }
        public ReadClienteDto Cliente { get; set; }
        public ReadFuncionarioDto Funcionario { get; set; }
        public ReadPetDto Pet { get; set; }
        public List<ReadProdutoDto>? Produtos { get; set; }
        public List<ReadPagamentoDto>? Pagamentos { get; set; }

    }

    public static class ReadServicoDtoConversions
    {
        public static ReadServicoDto toReadServicoDto(this Entities.EntitiesContext.Servico Servico)
        {
            ReadServicoDto ServicoDto = new ReadServicoDto();

            ServicoDto.Id = Servico.Id;
            ServicoDto.Cliente = Servico.IdClienteNavigation.toReadClienteDto();
            ServicoDto.Funcionario = Servico.IdFuncionarioNavigation.toReadFuncionarioDto();
            ServicoDto.Pet = Servico.IdPetNavigation.toReadPetDto();
            ServicoDto.DataEntrada = Servico.DataEntrada;
            ServicoDto.DataSaida = Servico.DataSaida;
            ServicoDto.Descricao = Servico.Descricao;
            ServicoDto.Produtos = Servico.ServicoProduto.Select(a => a.IdProdutoNavigation.toReadProdutoDto()).ToList();

            return ServicoDto;
        }

        public static void fromUpdateServicoDto(this Entities.EntitiesContext.Servico Servico, UpdateServicoDto ServicoDto)
        {
            Servico.IdCliente = ServicoDto.IdCliente;
            Servico.IdFuncionario = ServicoDto.IdFuncionario;
            Servico.IdPet = ServicoDto.IdPet;
            Servico.DataEntrada = ServicoDto.GetDataEntrada();
            Servico.DataSaida = ServicoDto.GetDataSaida();
            Servico.Descricao = ServicoDto.Descricao;
        }

        public static Entities.EntitiesContext.Servico toCreateServicoDto(this CreateServicoDto ServicoDto)
        {
            Entities.EntitiesContext.Servico Servico = new Entities.EntitiesContext.Servico();
            Servico.IdCliente = ServicoDto.IdCliente;
            Servico.IdFuncionario = ServicoDto.IdFuncionario;
            Servico.IdPet = ServicoDto.IdPet;
            Servico.DataEntrada = ServicoDto.GetDataEntrada();
            Servico.DataSaida = ServicoDto.GetDataSaida();
            Servico.Descricao = ServicoDto.Descricao;

            return Servico;
        }
    }
}
