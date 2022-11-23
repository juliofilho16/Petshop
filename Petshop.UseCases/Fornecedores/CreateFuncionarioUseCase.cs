using Petshop.Borders.Dtos.Repositories.Fornecedores;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Fornecedores;

namespace Petshop.UseCases.Fornecedores
{
    public class CreateFornecedoresUseCase : ICreateFornecedorUseCase
    {
        private readonly IFornecedoresRepository _fornecedoresRepository;

        public CreateFornecedoresUseCase(IFornecedoresRepository FornecedoresRepository)
        {
            _fornecedoresRepository = FornecedoresRepository;
        }

        public UseCaseResponse<int> Execute(UseCaseRequest<CreateFornecedorDto> request)
        {
            var response = new UseCaseResponse<int>();

            try
            {
                if (request == null || request.RequestValue == null)
                    throw new ArgumentNullException(nameof(request));

                var IdFornecedores = _fornecedoresRepository.CreateFornecedor(request.RequestValue!);
                response.SetResult(IdFornecedores);
            }
            catch (Exception ex)
            {
                response.SetError(ex.Message, null);
            }

            return response;

        }
    }
}
