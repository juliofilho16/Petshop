using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Petshop.Borders.Dtos.Repositories.Pet;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Entities.EntitiesContext;
using Petshop.Repositories.ConfigBase;

namespace Petshop.Repositories
{
    public class PetRepository : BaseRepository, IPetRepository
    {
        private IMapper _mapper;
        public PetRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public int CreatePet(CreatePetDto createPetDto)
        {
            Pet Pet = _mapper.Map<Pet>(createPetDto);
            Create(Pet);
            return Pet.Id;
        }
        private Pet GetEntityById(int id)
        {
            return Contexto.Pet.Where(a => a.Id == id)
                               .Include(b => b.IdEspecieNavigation)
                               .Include(b => b.IdRacaNavigation)
                               .First();
        }
        public ReadPetDto GetPet(int idPet)
        {
            var entity = GetEntityById(idPet);
            if (entity != null)
            {
                return entity.toReadPetDto();
            }

            return null!;
        }
        public List<ReadPetDto> GetListPets()
        {
            var listEntitys = Contexto.Pet.Include(b => b.IdEspecieNavigation)
                               .Include(b => b.IdRacaNavigation).ToList();

            if (listEntitys != null)
            {
                return listEntitys.Select(a => a.toReadPetDto()).ToList();
            }

            return null!;
        }
        public void UpdatePet(int idPet, UpdatePetDto updatePetDto)
        {
            Pet? entity = GetById<Pet>(idPet);

            if (entity == null)
            {
                throw new Exception("Pet não encontrada");
            }
            _mapper.Map(updatePetDto, entity);
            Edit(entity);
        }
    }
}