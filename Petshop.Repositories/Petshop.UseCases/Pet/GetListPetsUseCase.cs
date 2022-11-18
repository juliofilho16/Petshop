using Petshop.Borders.Dtos.Repositories.Pet;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Pet;

namespace Petshop.UseCases.Pet
{
    public class GetListPetsUseCase : IGetListPetsUseCase
    {
        private readonly IPetRepository _PetRepository;

        public GetListPetsUseCase(IPetRepository PetRepository)
        {
            _PetRepository = PetRepository;
        }

        public UseCaseResponse<List<ReadPetDto>> Execute(UseCaseRequest<int> request)
        {
            var response = new UseCaseResponse<List<ReadPetDto>>();

            try
            {
                if (request == null)
                    throw new ArgumentNullException(nameof(request));

                var list = _PetRepository.GetListPets();
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
