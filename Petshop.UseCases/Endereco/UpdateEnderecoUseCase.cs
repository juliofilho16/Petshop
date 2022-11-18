using Petshop.Borders.Dtos.Repositories.Endereco;
using Petshop.Borders.Dtos.UseCase.Common;
using Petshop.Borders.Dtos.UseCase.Endereco;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Endereco;

namespace Petshop.UseCases.Endereco
{
    public class UpdateEnderecoUseCase : IUpdateEnderecoUseCase
    {
        private readonly IEnderecoRepository _EnderecoRepository;
        public UpdateEnderecoUseCase(IEnderecoRepository EnderecoRepository)
        {
            _EnderecoRepository = EnderecoRepository;
        }
        
        public UseCaseResponse<int?> Execute(UpdateEnderecoRequest request)
        {
            var response = new UseCaseResponse<int?>();

            try
            {
                if (request == null || request.Id == 0 || request.UpdateEnderecoDto == null)
                    throw new ArgumentNullException(nameof(request));

                _EnderecoRepository.UpdateEndereco(request.Id,request.UpdateEnderecoDto!);
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
