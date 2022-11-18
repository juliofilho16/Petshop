using AutoMapper;
using Petshop.Borders.Dtos.Repositories.Funcionario;
using Petshop.Borders.Dtos.Repositories.Pessoa;
using Petshop.Entities.EntitiesContext;

namespace Petshop.Borders.Mappings
{
    public class FuncionarioProfile : Profile
    {
        public FuncionarioProfile()
        {
            CreateMap<CreateFuncionarioDto, Funcionario>();
            CreateMap<Funcionario, ReadFuncionarioDto>();
            CreateMap<UpdateFuncionarioDto, Funcionario>();
            CreateMap<CreateFuncionarioDto, CreatePessoaDto>().ReverseMap();
            CreateMap<UpdateFuncionarioDto, UpdatePessoaDto>().ReverseMap();
        }
    }
}
