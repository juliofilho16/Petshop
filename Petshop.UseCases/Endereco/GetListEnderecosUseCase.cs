using Petshop.Borders.Dtos.Repositories.Endereco;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Endereco;

namespace Petshop.UseCases.Endereco
{
    public class GetListEnderecosUseCase : IGetListEnderecosUseCase
    {
        private readonly IEnderecoRepository _EnderecoRepository;

        public GetListEnderecosUseCase(IEnderecoRepository EnderecoRepository)
        {
            _EnderecoRepository = EnderecoRepository;
        }

        public UseCaseResponse<List<ReadEnderecoDto>> Execute(UseCaseRequest<int> request)
        {
            var response = new UseCaseResponse<List<ReadEnderecoDto>>();

            try
            {
                if (request == null)
                    throw new ArgumentNullException(nameof(request));

                var list = _EnderecoRepository.GetListEnderecos(request.RequestValue);
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
