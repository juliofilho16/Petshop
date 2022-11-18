using AutoMapper;
using Petshop.Borders.Dtos.Repositories.Pet;
using Petshop.Entities.EntitiesContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Mappings
{
    public class PetProfile : Profile
    {
        public PetProfile()
        {
            CreateMap<CreatePetDto, Pet>();
            CreateMap<Pet, ReadPetDto>();
            CreateMap<UpdatePetDto, Pet>();
        }
    }
}
