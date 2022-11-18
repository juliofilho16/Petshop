using Petshop.Borders.Dtos.Repositories.Pet;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Pet;

namespace Petshop.UseCases.Pet
{
    public class GetPetUseCase : IGetPetUseCase
    {
        private readonly IPetRepository _PetRepository;

        public GetPetUseCase(IPetRepository PetRepository)
        {
            _PetRepository = PetRepository;
        }

        public UseCaseResponse<ReadPetDto> Execute(UseCaseRequest<int> request)
        {
            var response = new UseCaseResponse<ReadPetDto>();

            try
            {
                if (request == null)
                    throw new ArgumentNullException(nameof(request));

                var PetResult = _PetRepository.GetPet(request.RequestValue);
                response.SetResult(PetResult);
            }
            catch (Exception ex)
            {
                response.SetError(ex.Message, null);
            }

            return response;
        }
    }
}
