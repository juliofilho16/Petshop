using Petshop.Borders.Dtos.Repositories.Especie;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Especie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.UseCases.Especie
{
    public class GetListEspeciesUseCase : IGetListEspeciesUseCase
    {
        private readonly IEspecieRepository _EspecieRepository;

        public GetListEspeciesUseCase(IEspecieRepository EspecieRepository)
        {
            _EspecieRepository = EspecieRepository;
        }

        public UseCaseResponse<List<ReadEspecieDto>> Execute(UseCaseRequest<int> request)
        {
            var response = new UseCaseResponse<List<ReadEspecieDto>>();

            try
            {
                if (request == null)
                    throw new ArgumentNullException(nameof(request));

                var list = _EspecieRepository.GetListEspecies();
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
