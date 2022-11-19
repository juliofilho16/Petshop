using Petshop.Borders.Dtos.Repositories.Produto;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Produto;

namespace Petshop.UseCases.Produto
{
    public class DeleteProdutoUseCase : IDeleteProdutoUseCase
    {
        private readonly IProdutoRepository _ProdutoRepository;

        public DeleteProdutoUseCase(IProdutoRepository ProdutoRepository)
        {
            _ProdutoRepository = ProdutoRepository;
        }

        public UseCaseResponse<int?> Execute(UseCaseRequest<int> request)
        {
            var response = new UseCaseResponse<int?>();

            try
            {
                if (request == null)
                    throw new ArgumentNullException(nameof(request));

                _ProdutoRepository.DeleteProduto(request.RequestValue);
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
