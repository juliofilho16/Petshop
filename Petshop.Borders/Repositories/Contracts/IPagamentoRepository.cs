using Petshop.Borders.Dtos.Repositories.Pagamento;

namespace Petshop.Borders.Repositories.Contracts
{
    public interface IPagamentoRepository
    {
        List<ReadPagamentoDto> GetPagamentos(int IdServico);
        int CreatePagamento(CreatePagamentoDto createPagamentoDto);
        void UpdatePagamento(int idPagamento, UpdatePagamentoDto updatePagamentoDto);
        void DeletePagamento(int idPagamento);
    }
}
