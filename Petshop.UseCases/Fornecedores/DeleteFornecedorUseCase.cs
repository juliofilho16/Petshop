﻿using Petshop.Borders.Dtos.Repositories.Fornecedores;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Fornecedores;

namespace Petshop.UseCases.Fornecedores
{
    public class DeleteFornecedorUseCase : IDeleteFornecedorUseCase
    {
        private readonly IFornecedoresRepository _FornecedorRepository;

        public DeleteFornecedorUseCase(IFornecedoresRepository FornecedorRepository)
        {
            _FornecedorRepository = FornecedorRepository;
        }

        public UseCaseResponse<int?> Execute(UseCaseRequest<int> request)
        {
            var response = new UseCaseResponse<int?>();

            try
            {
                if (request == null)
                    throw new ArgumentNullException(nameof(request));

                _FornecedorRepository.DeleteFornecedor(request.RequestValue);
                response.SetResult(null);
            }
            catch (Exception ex)
            {
                response.SetError(ex.Message, null);
            }

            return response;
        }
    }
}
