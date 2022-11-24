using Petshop.Borders.Dtos.Repositories.Cliente;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Cliente;

namespace Petshop.UseCases.Cliente
{
    public class DeleteClienteUseCase : IDeleteClienteUseCase
    {
        private readonly IClienteRepository _ClienteRepository;

        public DeleteClienteUseCase(IClienteRepository ClienteRepository)
        {
            _ClienteRepository = ClienteRepository;
        }

        public UseCaseResponse<int?> Execute(UseCaseRequest<int> request)
        {
            var response = new UseCaseResponse<int?>();

            try
            {
                if (request == null)
                    throw new ArgumentNullException(nameof(request));

                _ClienteRepository.DeleteCliente(request.RequestValue);
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
