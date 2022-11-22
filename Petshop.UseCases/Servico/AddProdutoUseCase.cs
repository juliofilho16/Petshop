using Petshop.Borders.Dtos.Repositories.Servico;
using Petshop.Borders.Dtos.UseCase.Common;
using Petshop.Borders.Dtos.UseCase.Servico;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Servico;

namespace Petshop.UseCases.Servico
{
    public class AddProdutoUseCase : IAddProdutoUseCase
    {
        private readonly IServicoRepository _servicoRepository;
        public AddProdutoUseCase(IServicoRepository ServicoRepository)
        {
            _servicoRepository = ServicoRepository;
        }

        public UseCaseResponse<int?> Execute(UseCaseRequest<AddProdutoRequest> request)
        {
            var response = new UseCaseResponse<int?>();

            try
            {
                if (request == null ||  request.RequestValue == null)
                    throw new ArgumentNullException(nameof(request));

                _servicoRepository.AddProduto(request.RequestValue.IdServico, request.RequestValue.IdProduto);
                response.SetResult(null);
            }
            catch (Exception ex)
            {
                response.SetError(ex.Message, ExtensionsException.GetInnerExceptionMessages(ex));
            }

            return response;
        }
    }
}
