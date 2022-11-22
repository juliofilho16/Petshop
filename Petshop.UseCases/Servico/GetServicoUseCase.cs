using Petshop.Borders.Dtos.Repositories.Servico;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Servico;

namespace Petshop.UseCases.Servico
{
    public class GetServicoUseCase : IGetServicoUseCase
    {
        private readonly IServicoRepository _servicoRepository;

        public GetServicoUseCase(IServicoRepository ServicoRepository)
        {
            _servicoRepository = ServicoRepository;
        }

        public UseCaseResponse<ReadServicoDto> Execute(UseCaseRequest<int> request)
        {
            var response = new UseCaseResponse<ReadServicoDto>();

            try
            {
                if (request == null)
                    throw new ArgumentNullException(nameof(request));

                var ServicoResult = _servicoRepository.GetServico(request.RequestValue);
                response.SetResult(ServicoResult);
            }
            catch (Exception ex)
            {
                response.SetError(ex.Message, null);
            }

            return response;
        }
    }
}
