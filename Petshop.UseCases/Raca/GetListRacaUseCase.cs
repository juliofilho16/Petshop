using Petshop.Borders.Dtos.Repositories.Raca;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Raca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.UseCases.Raca
{
    public class GetListRacaUseCase : IGetListRacasUseCase
    {
        private readonly IRacaRepository _RacaRepository;

        public GetListRacaUseCase(IRacaRepository RacaRepository)
        {
            _RacaRepository = RacaRepository;
        }

        public UseCaseResponse<List<ReadRacaDto>> Execute(UseCaseRequest<int> request)
        {
            var response = new UseCaseResponse<List<ReadRacaDto>>();

            try
            {
                if (request == null)
                    throw new ArgumentNullException(nameof(request));

                var list = _RacaRepository.GetListRacas();
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
