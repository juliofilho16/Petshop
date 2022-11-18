using Petshop.Borders.Dtos.Repositories.Endereco;
using Petshop.Borders.Dtos.UseCase.Endereco;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Endereco;

namespace Petshop.UseCases.Endereco
{
    public class CreateEnderecoUseCase : ICreateEnderecoUseCase
    {
        private readonly IEnderecoRepository _EnderecoRepository;

        public CreateEnderecoUseCase(IEnderecoRepository EnderecoRepository)
        {
            _EnderecoRepository = EnderecoRepository;
        }

        public UseCaseResponse<int> Execute(CreateEnderecoRequest request)
        {
            var response = new UseCaseResponse<int>();

            try
            {
                if (request == null || request.IdPessoa == 0|| request.CreateEnderecoDto == null)
                    throw new ArgumentNullException(nameof(request));

                var IdEndereco = _EnderecoRepository.CreateEndereco(request.IdPessoa, request.CreateEnderecoDto!);
                response.SetResult(IdEndereco);
            }
            catch (Exception ex)
            {
                response.SetError(ex.Message, null);
            }

            return response;

        }
    }
}
