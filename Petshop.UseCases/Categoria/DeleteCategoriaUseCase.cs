using Petshop.Borders.Dtos.Repositories.Categoria;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Categoria;

namespace Petshop.UseCases.Categoria
{
    public class DeleteCategoriaUseCase : IDeleteCategoriaUseCase
    {
        private readonly ICategoriaRepository _CategoriaRepository;

        public DeleteCategoriaUseCase(ICategoriaRepository CategoriaRepository)
        {
            _CategoriaRepository = CategoriaRepository;
        }

        public UseCaseResponse<int?> Execute(UseCaseRequest<int> request)
        {
            var response = new UseCaseResponse<int?>();

            try
            {
                if (request == null)
                    throw new ArgumentNullException(nameof(request));

                _CategoriaRepository.DeleteCategoria(request.RequestValue);
                response.SetResult(null);
            }
            catch (Exception ex)
            {
                response.SetError(ex.Message, null);
            }

            return response;
        }
    }
}
