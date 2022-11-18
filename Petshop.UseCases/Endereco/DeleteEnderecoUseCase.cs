using Petshop.Borders.Dtos.Repositories.Endereco;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Endereco;

namespace Petshop.UseCases.Endereco
{
    public class DeleteEnderecoUseCase : IDeleteEnderecoUseCase
    {
        private readonly IEnderecoRepository _EnderecoRepository;

        public DeleteEnderecoUseCase(IEnderecoRepository EnderecoRepository)
        {
            _EnderecoRepository = EnderecoRepository;
        }

        public UseCaseResponse<int?> Execute(UseCaseRequest<int> request)
        {
            var response = new UseCaseResponse<int?>();

            try
            {
                if (request == null)
                    throw new ArgumentNullException(nameof(request));

                _EnderecoRepository.DeleteEndereco(request.RequestValue);
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
