using Petshop.Borders.Dtos.Repositories.Produto;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Produto;

namespace Petshop.UseCases.Produto
{
    public class CreateProdutoUseCase : ICreateProdutoUseCase
    {
        private readonly IProdutoRepository _ProdutoRepository;

        public CreateProdutoUseCase(IProdutoRepository ProdutoRepository)
        {
            _ProdutoRepository = ProdutoRepository;
        }

        public UseCaseResponse<int> Execute(UseCaseRequest<CreateProdutoDto> request)
        {
            var response = new UseCaseResponse<int>();

            try
            {
                if (request == null || request.RequestValue == null)
                    throw new ArgumentNullException(nameof(request));

                var IdProduto = _ProdutoRepository.CreateProduto(request.RequestValue!);
                response.SetResult(IdProduto);
            }
            catch (Exception ex)
            {
                response.SetError(ex.Message, null);
            }

            return response;

        }
    }
}
