using Petshop.Borders.Dtos.Repositories.Cliente;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Cliente;

namespace Petshop.UseCases.Cliente
{
    public class CreateClienteUseCase : ICreateClienteUseCase
    {
        private readonly IClienteRepository _clienteRepository;

        public CreateClienteUseCase(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public UseCaseResponse<int> Execute(UseCaseRequest<CreateClienteDto> request)
        {
            var response = new UseCaseResponse<int>();

            try
            {
                if (request == null || request.RequestValue == null)
                    throw new ArgumentNullException(nameof(request));

                var IdCliente = _clienteRepository.CreateCliente(request.RequestValue!);
                response.SetResult(IdCliente);
            }
            catch (Exception ex)
            {
                response.SetError(ex.Message, null);
            }

            return response;

        }
    }
}
