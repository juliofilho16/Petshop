using Petshop.Borders.Dtos.Repositories.Cidade;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Cidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.UseCases.Cidade
{
    public class GetListCidadesUseCase : IGetListCidadesUseCase
    {
        private readonly ICidadeRepository _CidadeRepository;

        public GetListCidadesUseCase(ICidadeRepository CidadeRepository)
        {
            _CidadeRepository = CidadeRepository;
        }

        public UseCaseResponse<List<ReadCidadeDto>> Execute(UseCaseRequest<int> request)
        {
            var response = new UseCaseResponse<List<ReadCidadeDto>>();

            try
            {
                if (request == null)
                    throw new ArgumentNullException(nameof(request));

                var list = _CidadeRepository.GetListCidades();
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
