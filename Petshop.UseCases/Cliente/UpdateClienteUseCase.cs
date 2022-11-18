using Petshop.Borders.Dtos.Repositories.Cliente;
using Petshop.Borders.Dtos.UseCase.Common;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Cliente;

namespace Petshop.UseCases.Cliente
{
    public class UpdateClienteUseCase : IUpdateClienteUseCase
    {
        private readonly IClienteRepository _clienteRepository;

        public UpdateClienteUseCase(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public UseCaseResponse<int?> Execute(UpdateRequestBase<UpdateClienteDto> request)
        {
            var response = new UseCaseResponse<int?>();

            try
            {
                if (request == null || request.Id == 0 || request.ModelValue == null)
                    throw new ArgumentNullException(nameof(request));

                _clienteRepository.UpdateCliente(request.Id,request.ModelValue!);
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
