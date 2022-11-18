using Petshop.Borders.Dtos.Repositories.Categoria;
using Petshop.Borders.Dtos.UseCase.Categoria;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Categoria;

namespace Petshop.UseCases.Categoria
{
    public class CreateCategoriaUseCase : ICreateCategoriaUseCase
    {
        private readonly ICategoriaRepository _CategoriaRepository;

        public CreateCategoriaUseCase(ICategoriaRepository CategoriaRepository)
        {
            _CategoriaRepository = CategoriaRepository;
        }

        public UseCaseResponse<int> Execute(UseCaseRequest<CreateCategoriaDto> request)
        {
            var response = new UseCaseResponse<int>();

            try
            {
                if (request == null || request.RequestValue == null)
                    throw new ArgumentNullException(nameof(request));

                var IdCategoria = _CategoriaRepository.CreateCategoria(request.RequestValue!);
                response.SetResult(IdCategoria);
            }
            catch (Exception ex)
            {
                response.SetError(ex.Message, null);
            }

            return response;

        }
    }
}
