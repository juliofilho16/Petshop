using Petshop.Borders.Dtos.Repositories.Categoria;

namespace Petshop.Borders.Repositories.Contracts
{
    public interface ICategoriaRepository
    {
        List<ReadCategoriaDto> GetListCategorias();
        List<ReadCategoriaDto> GetCategoriasProduto(int IdProduto);
        ReadCategoriaDto GetCategoria(int idCategoria);
        int CreateCategoria(CreateCategoriaDto createCategoriaDto);
        void UpdateCategoria(int idCategoria, UpdateCategoriaDto updateCategoriaDto);
        void DeleteCategoria(int idCategoria);


    }
}
