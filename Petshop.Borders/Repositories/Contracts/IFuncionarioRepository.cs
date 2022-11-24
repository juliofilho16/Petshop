using Petshop.Borders.Dtos.Repositories.Funcionario;

namespace Petshop.Borders.Repositories.Contracts
{
    public interface IFuncionarioRepository
    {
        List<ReadFuncionarioDto> GetListFuncionarios();
        ReadFuncionarioDto GetFuncionario(int idFuncionario);
        int CreateFuncionario(CreateFuncionarioDto createFuncionarioDto);
        void UpdateFuncionario(int idFuncionario, UpdateFuncionarioDto updateFuncionarioDto);
        void DeleteFuncionario(int idFuncionario);
    }
}
