using Petshop.Borders.Dtos.Repositories.Servico;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Servico;

namespace Petshop.UseCases.Servico
{
    public class CreateServicoUseCase : ICreateServicoUseCase
    {
        private readonly IServicoRepository _servicoRepository;

        public CreateServicoUseCase(IServicoRepository ServicoRepository)
        {
            _servicoRepository = ServicoRepository;
        }

        public UseCaseResponse<int> Execute(UseCaseRequest<CreateServicoDto> request)
        {
            var response = new UseCaseResponse<int>();

            try
            {
                if (request == null || request.RequestValue == null)
                    throw new ArgumentNullException(nameof(request));

                var IdServico = _servicoRepository.CreateServico(request.RequestValue!);
                response.SetResult(IdServico);
            }
            catch (Exception ex)
            {
                response.SetError(ex.Message, ExtensionsException.GetInnerExceptionMessages(ex));
            }

            return response;

        }
    }
}
