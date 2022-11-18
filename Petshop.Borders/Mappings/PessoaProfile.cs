using AutoMapper;
using Petshop.Borders.Dtos.Repositories.Cliente;
using Petshop.Borders.Dtos.Repositories.Pessoa;
using Petshop.Entities.EntitiesContext;

namespace Petshop.Borders.Mappings
{
    public class PessoaProfile : Profile
    {
        public PessoaProfile()
        {
            CreateMap<CreatePessoaDto, Pessoa>();
            CreateMap<Pessoa, ReadPessoaDto>();
            CreateMap<Pessoa, ReadClienteDto>();
            CreateMap<UpdatePessoaDto, Pessoa>();
        }
    }
}
