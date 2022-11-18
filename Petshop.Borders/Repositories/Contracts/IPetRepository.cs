using Petshop.Borders.Dtos.Repositories.Pet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Repositories.Contracts
{
    public interface IPetRepository
    {
        List<ReadPetDto> GetListPets();
        ReadPetDto GetPet(int idPet);
        int CreatePet(CreatePetDto createPetDto);
        void UpdatePet(int idPet, UpdatePetDto updatePetDto);
    }
}
