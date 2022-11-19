using Petshop.Borders.Dtos.Repositories.Produto;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Produto;

namespace Petshop.UseCases.Produto
{
    public class GetListProdutosUseCase : IGetListProdutosUseCase
    {
        private readonly IProdutoRepository _ProdutoRepository;

        public GetListProdutosUseCase(IProdutoRepository ProdutoRepository)
        {
            _ProdutoRepository = ProdutoRepository;
        }

        public UseCaseResponse<List<ReadProdutoDto>> Execute(UseCaseRequest<int> request)
        {
            var response = new UseCaseResponse<List<ReadProdutoDto>>();

            try
            {
                if (request == null)
                    throw new ArgumentNullException(nameof(request));

                var list = _ProdutoRepository.GetListProdutos();
                response.SetResult(list);
            }
            catch (Exception ex)
            {
                response.SetError(ex.Message, null);
            }

            return response;
        }
    }
}
