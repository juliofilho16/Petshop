using AutoMapper;
using Petshop.Borders.Dtos.Repositories.Produto;
using Petshop.Entities.EntitiesContext;

namespace Produtoshop.Borders.Mappings
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<CreateProdutoDto, Produto>();
            CreateMap<Produto, ReadProdutoDto>();
            CreateMap<UpdateProdutoDto, Produto>();
        }
    }
}
