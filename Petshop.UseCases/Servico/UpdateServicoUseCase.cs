using Petshop.Borders.Dtos.Repositories.Servico;
using Petshop.Borders.Dtos.UseCase.Common;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Servico;

namespace Petshop.UseCases.Servico
{
    public class UpdateServicoUseCase : IUpdateServicoUseCase
    {
        private readonly IServicoRepository _servicoRepository;
        public UpdateServicoUseCase(IServicoRepository ServicoRepository)
        {
            _servicoRepository = ServicoRepository;
        }

        public UseCaseResponse<int?> Execute(UpdateRequestBase<UpdateServicoDto> request)
        {
            var response = new UseCaseResponse<int?>();

            try
            {
                if (request == null || request.Id == 0 || request.ModelValue == null)
                    throw new ArgumentNullException(nameof(request));

                _servicoRepository.UpdateServico(request.Id, request.ModelValue!);
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
