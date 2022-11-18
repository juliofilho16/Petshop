using AutoMapper;
using Petshop.Borders.Dtos.Repositories.Pagamento;
using Petshop.Entities.EntitiesContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Mappings
{
    public class PagamentoProfile : Profile
    {
        public PagamentoProfile()
        {
            CreateMap<CreatePagamentoDto, Pagamento>();
            CreateMap<Pagamento, ReadPagamentoDto>();
            CreateMap<UpdatePagamentoDto, Pagamento>();
        }
    }
}
