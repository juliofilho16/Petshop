using Petshop.Borders.Dtos.Repositories.Categoria;
using Petshop.Borders.Dtos.UseCase.Common;
using Petshop.Borders.Dtos.UseCase.Categoria;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Categoria;

namespace Petshop.UseCases.Categoria
{
    public class UpdateCategoriaUseCase : IUpdateCategoriaUseCase
    {
        private readonly ICategoriaRepository _CategoriaRepository;
        public UpdateCategoriaUseCase(ICategoriaRepository CategoriaRepository)
        {
            _CategoriaRepository = CategoriaRepository;
        }

        public UseCaseResponse<int?> Execute(UpdateRequestBase<UpdateCategoriaDto> request)
        {
            var response = new UseCaseResponse<int?>();

            try
            {
                if (request == null || request.Id == 0 || request.ModelValue == null)
                    throw new ArgumentNullException(nameof(request));

                _CategoriaRepository.UpdateCategoria(request.Id, request.ModelValue!);
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
