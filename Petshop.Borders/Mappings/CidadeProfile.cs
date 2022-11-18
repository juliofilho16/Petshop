using AutoMapper;
using Petshop.Borders.Dtos.Repositories.Cidade;
using Petshop.Entities.EntitiesContext;

namespace Petshop.Borders.Mappings
{
    public class CidadeProfile : Profile
    {
        public CidadeProfile()
        {
            CreateMap<CreateCidadeDto, Cidade>();
            CreateMap<Cidade, ReadCidadeDto>();
            CreateMap<UpdateCidadeDto, Cidade>();
        }
    }
}
