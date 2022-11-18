using AutoMapper;
using Petshop.Borders.Dtos.Repositories.Estado;
using Petshop.Entities.EntitiesContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Mappings
{
    public class EstadoProfile : Profile
    {
        public EstadoProfile()
        {
            CreateMap<CreateEstadoDto, Estado>();
            CreateMap<Estado, ReadEstadoDto>();
            CreateMap<UpdateEstadoDto, Estado>();
        }
    }
}
