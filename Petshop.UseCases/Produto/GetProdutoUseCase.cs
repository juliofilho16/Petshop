using Petshop.Borders.Dtos.Repositories.Produto;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Produto;

namespace Petshop.UseCases.Produto
{
    public class GetProdutoUseCase : IGetProdutoUseCase
    {
        private readonly IProdutoRepository _ProdutoRepository;

        public GetProdutoUseCase(IProdutoRepository ProdutoRepository)
        {
            _ProdutoRepository = ProdutoRepository;
        }

        public UseCaseResponse<ReadProdutoDto> Execute(UseCaseRequest<int> request)
        {
            var response = new UseCaseResponse<ReadProdutoDto>();

            try
            {
                if (request == null)
                    throw new ArgumentNullException(nameof(request));

                var ProdutoResult = _ProdutoRepository.GetProduto(request.RequestValue);
                response.SetResult(ProdutoResult);
            }
            catch (Exception ex)
            {
                response.SetError(ex.Message, null);
            }

            return response;
        }
    }
}
