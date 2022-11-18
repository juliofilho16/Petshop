using Petshop.Borders.Mappings;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Repositories;

namespace Petshop.Configurations
{
    public class RepositoriesConfig
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<ICidadeRepository, CidadeRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IEspecieRepository, EspecieRepository>();
            services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();
            services.AddScoped<IPagamentoRepository, PagamentoRepository>();
            services.AddScoped<IPessoaRepository, PessoaRepository>();
            services.AddScoped<IPetRepository, PetRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IRacaRepository, RacaRepository>();
            services.AddScoped<IServicoRepository, ServicoRepository>();
        }
    }
}
