using Petshop.Borders.Dtos.Repositories.Pagamento;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Pagamento;

namespace Petshop.UseCases.Pagamento
{
    public class DeletePagamentoUseCase : IDeletePagamentoUseCase
    {
        private readonly IPagamentoRepository _PagamentoRepository;

        public DeletePagamentoUseCase(IPagamentoRepository PagamentoRepository)
        {
            _PagamentoRepository = PagamentoRepository;
        }

        public UseCaseResponse<int?> Execute(UseCaseRequest<int> request)
        {
            var response = new UseCaseResponse<int?>();

            try
            {
                if (request == null)
                    throw new ArgumentNullException(nameof(request));

                _PagamentoRepository.DeletePagamento(request.RequestValue);
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
