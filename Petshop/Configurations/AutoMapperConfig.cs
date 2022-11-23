using AutoMapper;
using Fornecedoresshop.Borders.Mappings;
using Petshop.Borders.Mappings;
using Petshop.Entities.EntitiesContext;
using Produtoshop.Borders.Mappings;

namespace Petshop.Api.Configurations
{
    public static class AutoMapperConfig
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new CategoriaProfile());
                cfg.AddProfile(new CidadeProfile());
                cfg.AddProfile(new ClienteProfile());
                cfg.AddProfile(new EnderecoProfile());
                cfg.AddProfile(new EspecieProfile());
                cfg.AddProfile(new EstadoProfile());
                cfg.AddProfile(new FuncionarioProfile());
                cfg.AddProfile(new PagamentoProfile());
                cfg.AddProfile(new PessoaProfile());
                cfg.AddProfile(new PetProfile());
                cfg.AddProfile(new ProdutoProfile());
                cfg.AddProfile(new RacaProfile());
                cfg.AddProfile(new ServicoProdutoProfile());
                cfg.AddProfile(new ServicoProfile());
                cfg.AddProfile(new FornecedoresProfile());
                
            });
            var mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

        }
    }
}
