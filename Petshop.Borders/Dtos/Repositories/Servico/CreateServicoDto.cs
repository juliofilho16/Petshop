using Petshop.Borders.Dtos.Repositories.ServicoProduto;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Net.Http.Headers;

namespace Petshop.Borders.Dtos.Repositories.Servico
{
    public class CreateServicoDto
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Campo Cliente deve ser preenchido")]
        public int IdCliente { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Campo Funcionario deve ser preenchido")]
        public int IdFuncionario { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Campo Pet deve ser preenchido")]
        public int IdPet { get; set; }
        [Required]
        public string DtEntrada
        {
            get { return DataEntrada.ToString("dd/MM/yyyy HH:mm"); }
            set
            { if (!string.IsNullOrEmpty(value)) DataEntrada = Convert.ToDateTime(value, new CultureInfo("pt-Br")); }
        }
        private DateTime DataEntrada { get; set; }
        [Required]
        public string? DtSaida { get { return DataSaida.HasValue ? DataSaida.Value.ToString("dd/MM/yyyy HH:mm") : null; } set { DataSaida = string.IsNullOrEmpty(value) ? null : Convert.ToDateTime(value, new CultureInfo("pt-Br")); } }
        private DateTime? DataSaida { get; set; }

        [Required]
        [StringLength(256)]
        public string Descricao { get; set; }
        //public List<CreateServicoProdutoDto> Produtos { get; set; }

        public DateTime GetDataEntrada() { return DataEntrada; }

        public DateTime? GetDataSaida() { return DataSaida; }

    }
}
