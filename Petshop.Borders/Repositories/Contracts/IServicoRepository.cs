using Petshop.Borders.Dtos.Repositories.Servico;

namespace Petshop.Borders.Repositories.Contracts
{
    public interface IServicoRepository
    {
        List<ReadServicoDto> GetListServicos();
        ReadServicoDto GetServico(int idServico);
        int CreateServico(CreateServicoDto createServicoDto);
        void UpdateServico(int idServico, UpdateServicoDto updateServicoDto);
        void DeleteServico(int idServico);
        void AddProduto(int idServico, int idProduto);
    }
}
