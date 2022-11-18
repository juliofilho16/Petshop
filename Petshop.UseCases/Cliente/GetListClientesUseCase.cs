using Petshop.Borders.Dtos.Repositories.Cliente;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Cliente;

namespace Petshop.UseCases.Cliente
{
    public class GetListClientesUseCase : IGetListClientesUseCase
    {
        private readonly IClienteRepository _clienteRepository;

        public GetListClientesUseCase(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public UseCaseResponse<List<ReadClienteDto>> Execute(UseCaseRequest<int> request)
        {
            var response = new UseCaseResponse<List<ReadClienteDto>>();

            try
            {
                if (request == null)
                    throw new ArgumentNullException(nameof(request));

                var list = _clienteRepository.GetListClientes();
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
