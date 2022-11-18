using Petshop.Borders.Dtos.Repositories.Cliente;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Cliente;

namespace Petshop.UseCases.Cliente
{
    public class GetClienteUseCase : IGetClienteUseCase
    {
        private readonly IClienteRepository _clienteRepository;

        public GetClienteUseCase(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public UseCaseResponse<ReadClienteDto> Execute(UseCaseRequest<int> request)
        {
            var response = new UseCaseResponse<ReadClienteDto>();

            try
            {
                if (request == null)
                    throw new ArgumentNullException(nameof(request));

                var clienteResult = _clienteRepository.GetCliente(request.RequestValue);
                response.SetResult(clienteResult);
            }
            catch (Exception ex)
            {
                response.SetError(ex.Message, null);
            }

            return response;
        }
    }
}
