using Petshop.Borders.Dtos.Repositories.Pagamento;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Pagamento;

namespace Petshop.UseCases.Pagamento
{
    public class CreatePagamentoUseCase : ICreatePagamentoUseCase
    {
        private readonly IPagamentoRepository _PagamentoRepository;

        public CreatePagamentoUseCase(IPagamentoRepository PagamentoRepository)
        {
            _PagamentoRepository = PagamentoRepository;
        }

        public UseCaseResponse<int> Execute(UseCaseRequest<CreatePagamentoDto> request)
        {
            var response = new UseCaseResponse<int>();

            try
            {
                if (request == null || request.RequestValue == null)
                    throw new ArgumentNullException(nameof(request));

                var IdPagamento = _PagamentoRepository.CreatePagamento(request.RequestValue!);
                response.SetResult(IdPagamento);
            }
            catch (Exception ex)
            {
                response.SetError(ex.Message, null);
            }

            return response;

        }
    }
}
