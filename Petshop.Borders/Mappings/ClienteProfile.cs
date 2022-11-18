using AutoMapper;
using Petshop.Borders.Dtos.Repositories.Cliente;
using Petshop.Borders.Dtos.Repositories.Pessoa;
using Petshop.Entities.EntitiesContext;

namespace Petshop.Borders.Mappings
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<CreateClienteDto, Cliente>();
            CreateMap<CreateClienteDto, CreatePessoaDto>().ReverseMap();
            CreateMap<ReadClienteDto, Pessoa>();
            CreateMap<Cliente, ReadClienteDto>();
            CreateMap<UpdateClienteDto, Cliente>();
            CreateMap<UpdateClienteDto, UpdatePessoaDto>().ReverseMap();
        }
    }
}
