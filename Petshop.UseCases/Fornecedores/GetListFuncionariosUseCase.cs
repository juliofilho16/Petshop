using Petshop.Borders.Dtos.Repositories.Fornecedores;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Fornecedores;

namespace Petshop.UseCases.Fornecedores
{
    public class GetListFornecedoressUseCase : IGetListFornecedoresUseCase
    {
        private readonly IFornecedoresRepository _FornecedoresRepository;

        public GetListFornecedoressUseCase(IFornecedoresRepository FornecedoresRepository)
        {
            _FornecedoresRepository = FornecedoresRepository;
        }

        public UseCaseResponse<List<ReadFornecedoresDto>> Execute(UseCaseRequest<int> request)
        {
            var response = new UseCaseResponse<List<ReadFornecedoresDto>>();

            try
            {
                if (request == null)
                    throw new ArgumentNullException(nameof(request));

                var list = _FornecedoresRepository.GetListFornecedores();
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
