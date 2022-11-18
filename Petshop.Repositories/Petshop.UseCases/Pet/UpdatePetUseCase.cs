using Petshop.Borders.Dtos.Repositories.Pet;
using Petshop.Borders.Dtos.UseCase.Common;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Pet;

namespace Petshop.UseCases.Pet
{
    public class UpdatePetUseCase : IUpdatePetUseCase
    {
        private readonly IPetRepository _PetRepository;

        public UpdatePetUseCase(IPetRepository PetRepository)
        {
            _PetRepository = PetRepository;
        }

        public UseCaseResponse<int?> Execute(UpdateRequestBase<UpdatePetDto> request)
        {
            var response = new UseCaseResponse<int?>();

            try
            {
                if (request == null || request.Id == 0 || request.ModelValue == null)
                    throw new ArgumentNullException(nameof(request));

                _PetRepository.UpdatePet(request.Id,request.ModelValue!);
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
