using Petshop.Borders.Dtos.Repositories.Pagamento;
using Petshop.Borders.Dtos.UseCase.Common;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Pagamento;

namespace Petshop.UseCases.Pagamento
{
    public class UpdatePagamentoUseCase : IUpdatePagamentoUseCase
    {
        private readonly IPagamentoRepository _PagamentoRepository;
        public UpdatePagamentoUseCase(IPagamentoRepository PagamentoRepository)
        {
            _PagamentoRepository = PagamentoRepository;
        }

        public UseCaseResponse<int?> Execute(UpdateRequestBase<UpdatePagamentoDto> request)
        {
            var response = new UseCaseResponse<int?>();

            try
            {
                if (request == null || request.Id == 0 || request.ModelValue == null)
                    throw new ArgumentNullException(nameof(request));

                _PagamentoRepository.UpdatePagamento(request.Id, request.ModelValue!);
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
