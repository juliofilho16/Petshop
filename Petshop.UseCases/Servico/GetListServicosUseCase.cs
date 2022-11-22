using Petshop.Borders.Dtos.Repositories.Servico;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Servico;

namespace Petshop.UseCases.Servico
{
    public class GetListServicosUseCase : IGetListServicosUseCase
    {
        private readonly IServicoRepository _servicoRepository;

        public GetListServicosUseCase(IServicoRepository ServicoRepository)
        {
            _servicoRepository = ServicoRepository;
        }

        public UseCaseResponse<List<ReadServicoDto>> Execute(UseCaseRequest<int> request)
        {
            var response = new UseCaseResponse<List<ReadServicoDto>>();

            try
            {
                if (request == null)
                    throw new ArgumentNullException(nameof(request));

                var list = _servicoRepository.GetListServicos();
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
