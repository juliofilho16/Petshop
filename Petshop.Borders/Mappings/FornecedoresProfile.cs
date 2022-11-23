using AutoMapper;
using Petshop.Borders.Dtos.Repositories.Fornecedores;
using Petshop.Entities.EntitiesContext;

namespace Fornecedoresshop.Borders.Mappings
{
    public class FornecedoresProfile : Profile
    {
        public FornecedoresProfile()
        {
            CreateMap<CreateFornecedorDto, Fornecedores>();
            CreateMap<Fornecedores, ReadFornecedoresDto>();
            CreateMap<UpdateFornecedorDto, Fornecedores>();
        }
    }
}
