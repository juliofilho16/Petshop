using Petshop.Borders.Dtos.Repositories.Categoria;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Categoria;

namespace Petshop.UseCases.Categoria
{
    public class GetCategoriaUseCase : IGetCategoriaUseCase
    {
        private readonly ICategoriaRepository _CategoriaRepository;

        public GetCategoriaUseCase(ICategoriaRepository CategoriaRepository)
        {
            _CategoriaRepository = CategoriaRepository;
        }

        public UseCaseResponse<ReadCategoriaDto> Execute(UseCaseRequest<int> request)
        {
            var response = new UseCaseResponse<ReadCategoriaDto>();

            try
            {
                if (request == null)
                    throw new ArgumentNullException(nameof(request));

                var CategoriaResult = _CategoriaRepository.GetCategoria(request.RequestValue);
                response.SetResult(CategoriaResult);
            }
            catch (Exception ex)
            {
                response.SetError(ex.Message, null);
            }

            return response;
        }
    }
}
