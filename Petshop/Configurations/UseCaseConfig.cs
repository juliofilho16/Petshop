using Petshop.Borders.UseCase.Categoria;
using Petshop.Borders.UseCase.Cidade;
using Petshop.Borders.UseCase.Cliente;
using Petshop.Borders.UseCase.Especie;
using Petshop.Borders.UseCase.Endereco;
using Petshop.Borders.UseCase.Pet;
using Petshop.Borders.UseCase.Raca;
using Petshop.UseCases.Categoria;
using Petshop.UseCases.Cidade;
using Petshop.UseCases.Cliente;
using Petshop.UseCases.Especie;
using Petshop.UseCases.Pet;
using Petshop.UseCases.Raca;
using Petshop.UseCases.Endereco;
using Petshop.Borders.UseCase.Produto;
using Petshop.UseCases.Produto;
using Petshop.Borders.UseCase.Servico;
using Petshop.UseCases.Servico;
using Petshop.Borders.UseCase.Pagamento;
using Petshop.UseCases.Pagamento;
using Petshop.Borders.UseCase.Fornecedores;
using Petshop.UseCases.Fornecedores;
using Petshop.Borders.UseCase.Funcionario;
using Petshop.UseCases.Funcionario;

namespace Petshop.Api.Configurations
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
            services.AddScoped<IDeleteClienteUseCase, DeleteClienteUseCase>();
            #endregion

            #region [Especie]
            services.AddScoped<IGetListEspeciesUseCase, GetListEspeciesUseCase>();
            #endregion 

            #region [Raca]
            services.AddScoped<IGetListRacasUseCase, GetListRacaUseCase>();
            #endregion

            #region [Pet]
            services.AddScoped<IUpdatePetUseCase, UpdatePetUseCase>();
            services.AddScoped<IGetListPetsUseCase, GetListPetsUseCase>();
            services.AddScoped<IGetPetUseCase, GetPetUseCase>();
            services.AddScoped<ICreatePetUseCase, CreatePetUseCase>();
            #endregion

            #region [Endereco]
            services.AddScoped<IUpdateEnderecoUseCase, UpdateEnderecoUseCase>();
            services.AddScoped<IGetListEnderecosUseCase, GetListEnderecosUseCase>();
            services.AddScoped<IGetEnderecoUseCase, GetEnderecoUseCase>();
            services.AddScoped<ICreateEnderecoUseCase, CreateEnderecoUseCase>();
            services.AddScoped<IDeleteEnderecoUseCase, DeleteEnderecoUseCase>();
            #endregion

            #region [Produto]
            services.AddScoped<IUpdateProdutoUseCase, UpdateProdutoUseCase>();
            services.AddScoped<IGetListProdutosUseCase, GetListProdutosUseCase>();
            services.AddScoped<IGetProdutoUseCase, GetProdutoUseCase>();
            services.AddScoped<ICreateProdutoUseCase, CreateProdutoUseCase>();
            services.AddScoped<IDeleteProdutoUseCase, DeleteProdutoUseCase>();
            #endregion

            #region [Pagamento]
            services.AddScoped<IUpdatePagamentoUseCase, UpdatePagamentoUseCase>();
            services.AddScoped<IGetListPagamentosUseCase, GetListPagamentosUseCase>();
            services.AddScoped<ICreatePagamentoUseCase, CreatePagamentoUseCase>();
            services.AddScoped<IDeletePagamentoUseCase, DeletePagamentoUseCase>();
            #endregion

            #region [Servico]
            services.AddScoped<IUpdateServicoUseCase, UpdateServicoUseCase>();
            services.AddScoped<IGetListServicosUseCase, GetListServicosUseCase>();
            services.AddScoped<IGetServicoUseCase, GetServicoUseCase>();
            services.AddScoped<ICreateServicoUseCase, CreateServicoUseCase>();
            services.AddScoped<IDeleteServicoUseCase, DeleteServicoUseCase>();
            services.AddScoped<IAddProdutoUseCase, AddProdutoUseCase>();
            #endregion

            #region [Fornecedor]
            services.AddScoped<IUpdateFornecedoresUseCase, UpdateFornecedoresUseCase>();
            services.AddScoped<IGetListFornecedoresUseCase, GetListFornecedoressUseCase>();
            services.AddScoped<IGetFornecedorUseCase, GetFornecedoresUseCase>();
            services.AddScoped<ICreateFornecedorUseCase, CreateFornecedoresUseCase>();
            services.AddScoped<IDeleteFornecedorUseCase, DeleteFornecedorUseCase>();
            #endregion

            #region [Funcionario]
            services.AddScoped<IGetFuncionarioUseCase, GetFuncionarioUseCase>();
            services.AddScoped<IGetListFuncionariosUseCase, GetListFuncionariosUseCase>();
            services.AddScoped<IUpdateFuncionarioUseCase, UpdateFuncionarioUseCase>();
            services.AddScoped<ICreateFuncionarioUseCase, CreateFuncionarioUseCase>();
            services.AddScoped<IDeleteFuncionarioUseCase, DeleteFuncionarioUseCase>();
            #endregion
        }
    }
}
