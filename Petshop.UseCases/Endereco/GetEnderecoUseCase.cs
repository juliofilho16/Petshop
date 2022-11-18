using Petshop.Borders.Dtos.Repositories.Endereco;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Endereco;

namespace Petshop.UseCases.Endereco
{
    public class GetEnderecoUseCase : IGetEnderecoUseCase
    {
        private readonly IEnderecoRepository _EnderecoRepository;

        public GetEnderecoUseCase(IEnderecoRepository EnderecoRepository)
        {
            _EnderecoRepository = EnderecoRepository;
        }

        public UseCaseResponse<ReadEnderecoDto> Execute(UseCaseRequest<int> request)
        {
            var response = new UseCaseResponse<ReadEnderecoDto>();

            try
            {
                if (request == null)
                    throw new ArgumentNullException(nameof(request));

                var EnderecoResult = _EnderecoRepository.GetEndereco(request.RequestValue);
                response.SetResult(EnderecoResult);
            }
            catch (Exception ex)
            {
                response.SetError(ex.Message, null);
            }

            return response;
        }
    }
}
