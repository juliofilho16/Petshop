using AutoMapper;
using Petshop.Borders.Dtos.Repositories.ServicoProduto;
using Petshop.Entities.EntitiesContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Mappings
{
    public class ServicoProdutoProfile : Profile
    {
        public ServicoProdutoProfile()
        {
            CreateMap<CreateServicoProdutoDto, ServicoProduto>();
            CreateMap<ServicoProduto, ReadServicoProdutoDto>();
        }
    }
}
