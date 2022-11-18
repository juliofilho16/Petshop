using AutoMapper;
using Petshop.Borders.Dtos.Repositories.Servico;
using Petshop.Entities.EntitiesContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Mappings
{
    public class ServicoProfile : Profile
    {
        public ServicoProfile()
        {
            CreateMap<CreateServicoDto, Servico>().ReverseMap();
            CreateMap<Servico, ReadServicoDto>().ReverseMap();
            CreateMap<UpdateServicoDto, Servico>().ReverseMap();
        }
    }
}
