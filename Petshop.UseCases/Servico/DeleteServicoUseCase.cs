using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Servico;

namespace Petshop.UseCases.Servico
{
    public class DeleteServicoUseCase : IDeleteServicoUseCase
    {
        private readonly IServicoRepository _servicoRepository;

        public DeleteServicoUseCase(IServicoRepository ServicoRepository)
        {
            _servicoRepository = ServicoRepository;
        }

        public UseCaseResponse<int?> Execute(UseCaseRequest<int> request)
        {
            var response = new UseCaseResponse<int?>();

            try
            {
                if (request == null)
                    throw new ArgumentNullException(nameof(request));

                _servicoRepository.DeleteServico(request.RequestValue);
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
