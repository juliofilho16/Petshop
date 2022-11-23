using Petshop.Borders.Dtos.Repositories.Fornecedores;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Fornecedores;

namespace Petshop.UseCases.Fornecedores
{
    public class GetFornecedoresUseCase : IGetFornecedorUseCase
    {
        private readonly IFornecedoresRepository _FornecedoresRepository;

        public GetFornecedoresUseCase(IFornecedoresRepository FornecedoresRepository)
        {
            _FornecedoresRepository = FornecedoresRepository;
        }

        public UseCaseResponse<ReadFornecedoresDto> Execute(UseCaseRequest<int> request)
        {
            var response = new UseCaseResponse<ReadFornecedoresDto>();

            try
            {
                if (request == null)
                    throw new ArgumentNullException(nameof(request));

                var FornecedoresResult = _FornecedoresRepository.GetFornecedor(request.RequestValue);
                response.SetResult(FornecedoresResult);
            }
            catch (Exception ex)
            {
                response.SetError(ex.Message, null);
            }

            return response;
        }
    }
}
