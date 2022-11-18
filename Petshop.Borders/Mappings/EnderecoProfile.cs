using AutoMapper;
using Petshop.Borders.Dtos.Repositories.Endereco;
using Petshop.Entities.EntitiesContext;

namespace Petshop.Borders.Mappings
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            CreateMap<CreateEnderecoDto, Endereco>();
            CreateMap<Endereco, ReadEnderecoDto>();
            CreateMap<UpdateEnderecoDto, Endereco>();
        }
    }
}
