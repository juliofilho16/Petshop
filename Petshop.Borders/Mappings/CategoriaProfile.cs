using AutoMapper;
using Petshop.Borders.Dtos.Repositories.Categoria;
using Petshop.Entities.EntitiesContext;

namespace Petshop.Borders.Mappings
{
    public class CategoriaProfile : Profile
    {
        public CategoriaProfile()
        {
            CreateMap<CreateCategoriaDto, Categoria>();
            CreateMap<Categoria, ReadCategoriaDto>();
            CreateMap<UpdateCategoriaDto, Categoria>();
        }
    }
}
