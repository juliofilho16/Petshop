using Petshop.Borders.Dtos.Repositories.Fornecedores;
using Petshop.Borders.Dtos.UseCase.Common;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Fornecedores;

namespace Petshop.UseCases.Fornecedores
{
    public class UpdateFornecedoresUseCase : IUpdateFornecedoresUseCase
    {
        private readonly IFornecedoresRepository _FornecedoresRepository;

        public UpdateFornecedoresUseCase(IFornecedoresRepository FornecedoresRepository)
        {
            _FornecedoresRepository = FornecedoresRepository;
        }

        public UseCaseResponse<int?> Execute(UpdateRequestBase<UpdateFornecedorDto> request)
        {
            var response = new UseCaseResponse<int?>();

            try
            {
                if (request == null || request.Id == 0 || request.ModelValue == null)
                    throw new ArgumentNullException(nameof(request));

                _FornecedoresRepository.UpdateFornecedor(request.Id,request.ModelValue!);
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
