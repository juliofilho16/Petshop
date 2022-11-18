using Petshop.Borders.Dtos.Repositories.Categoria;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Categoria;
using Petshop.Borders.Dtos.UseCase.Categoria;

namespace Petshop.UseCases.Categoria
{
    public class GetListCategoriasUseCase : IGetListCategoriasUseCase
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public GetListCategoriasUseCase(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public UseCaseResponse<List<ReadCategoriaDto>> Execute(GetListCategoriasRequest request)
        {
            var response = new UseCaseResponse<List<ReadCategoriaDto>>();

            try
            {
                if (request == null)
                    throw new ArgumentNullException(nameof(request));

                var list = new List<ReadCategoriaDto>();

                if (request.IdProduto == 0)
                {
                    list = _categoriaRepository.GetListCategorias();
                }
                else
                {
                    list = _categoriaRepository.GetCategoriasProduto(request.IdProduto);
                }
                response.SetResult(list);
            }
            catch (Exception ex)
            {
                response.SetError(ex.Message, null);
            }

            return response;
        }


    }
}
