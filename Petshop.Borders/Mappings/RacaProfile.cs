using AutoMapper;
using Petshop.Borders.Dtos.Repositories.Raca;
using Petshop.Entities.EntitiesContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Mappings
{
    public class RacaProfile : Profile
    {
        public RacaProfile()
        {
            CreateMap<CreateRacaDto, Raca>();
            CreateMap<Raca, ReadRacaDto>();
            CreateMap<UpdateRacaDto, Raca>();
        }
    }
}
