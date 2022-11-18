using AutoMapper;
using Petshop.Borders.Dtos.Repositories.Especie;
using Petshop.Entities.EntitiesContext;

namespace Petshop.Borders.Mappings
{
    public class EspecieProfile : Profile
    {
        public EspecieProfile()
        {
            CreateMap<CreateEspecieDto, Especie>();
            CreateMap<Especie, ReadEspecieDto>();
            CreateMap<UpdateEspecieDto, Especie>();
        }
    }
}
