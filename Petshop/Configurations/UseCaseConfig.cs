﻿using Petshop.Borders.UseCase.Categoria;
using Petshop.Borders.UseCase.Cidade;
using Petshop.Borders.UseCase.Cliente;
using Petshop.Borders.UseCase.Endereco;
using Petshop.Borders.UseCase.Pagamento;
using Petshop.Borders.UseCase.Pet;
using Petshop.Borders.UseCase.Produto;
using Petshop.Borders.UseCase.Raca;
using Petshop.UseCases.Categoria;
using Petshop.UseCases.Cidade;
using Petshop.UseCases.Cliente;
using Petshop.UseCases.Endereco;
using Petshop.UseCases.Pagamento;
using Petshop.UseCases.Produto;
using Petshop.UseCases.Raca;
using Petshop.UseCases.Pet;
using Petshop.Borders.UseCase.Especie;
using Petshop.UseCases.Especie;

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
        }
    }
}
