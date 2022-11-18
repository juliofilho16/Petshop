using Petshop.Borders.UseCase.Categoria;
using Petshop.Borders.UseCase.Cidade;
using Petshop.Borders.UseCase.Cliente;
using Petshop.UseCases.Categoria;
using Petshop.UseCases.Cidade;
using Petshop.UseCases.Cliente;

namespace Petshop.Configurations
{
    public class UseCaseConfig
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            #region [Categorias]
            services.AddScoped<IGetCategoriaUseCase, GetCategoriaUseCase>();
            services.AddScoped<IGetListCategoriasUseCase, GetListCategoriasUseCase>();
            services.AddScoped<IUpdateCategoriaUseCase, UpdateCategoriaUseCase>();
            services.AddScoped<ICreateCategoriaUseCase, CreateCategoriaUseCase>();
            services.AddScoped<IDeleteCategoriaUseCase, DeleteCategoriaUseCase>();
            #endregion 

            #region [Cidade]
            services.AddScoped<IGetListCidadesUseCase, GetListCidadesUseCase>();
            #endregion 

            #region [Cliente]
            services.AddScoped<IUpdateClienteUseCase, UpdateClienteUseCase>();
            services.AddScoped<IGetListClientesUseCase, GetListClientesUseCase>();
            services.AddScoped<IGetClienteUseCase, GetClienteUseCase>();
            services.AddScoped<ICreateClienteUseCase, CreateClienteUseCase>();
            #endregion

		 #region [Especie]
            services.AddScoped<IGetListEspeciesUseCase, GetListEspeciesUseCase>();
            #endregion

        }
    }
}
