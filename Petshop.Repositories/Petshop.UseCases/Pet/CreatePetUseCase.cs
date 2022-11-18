using Petshop.Borders.Dtos.Repositories.Pet;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Pet;

namespace Petshop.UseCases.Pet
{
    public class CreatePetUseCase : ICreatePetUseCase
    {
        private readonly IPetRepository _PetRepository;

        public CreatePetUseCase(IPetRepository PetRepository)
        {
            _PetRepository = PetRepository;
        }

        public UseCaseResponse<int> Execute(UseCaseRequest<CreatePetDto> request)
        {
            var response = new UseCaseResponse<int>();

            try
            {
                if (request == null || request.RequestValue == null)
                    throw new ArgumentNullException(nameof(request));

                var IdPet = _PetRepository.CreatePet(request.RequestValue!);
                response.SetResult(IdPet);
            }
            catch (Exception ex)
            {
                response.SetError(ex.Message, null);
            }

            return response;

        }
    }
}
