using Petshop.Borders.UseCase.Categoria;
using Petshop.UseCases.Categoria;

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
        }
    }
}
