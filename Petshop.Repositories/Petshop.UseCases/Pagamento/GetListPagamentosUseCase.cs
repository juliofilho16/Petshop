using Petshop.Borders.Dtos.Repositories.Pagamento;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Pagamento;

namespace Petshop.UseCases.Pagamento
{
    public class GetListPagamentosUseCase : IGetListPagamentosUseCase
    {
        private readonly IPagamentoRepository _PagamentoRepository;

        public GetListPagamentosUseCase(IPagamentoRepository PagamentoRepository)
        {
            _PagamentoRepository = PagamentoRepository;
        }

        public UseCaseResponse<List<ReadPagamentoDto>> Execute(UseCaseRequest<int> request)
        {
            var response = new UseCaseResponse<List<ReadPagamentoDto>>();

            try
            {
                if (request == null || request.RequestValue == 0)
                    throw new ArgumentNullException(nameof(request));

                var list = _PagamentoRepository.GetPagamentos(request.RequestValue);
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
