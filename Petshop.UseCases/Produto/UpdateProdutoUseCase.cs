using Petshop.Borders.Dtos.Repositories.Produto;
using Petshop.Borders.Dtos.UseCase.Common;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Produto;

namespace Petshop.UseCases.Produto
{
    public class UpdateProdutoUseCase : IUpdateProdutoUseCase
    {
        private readonly IProdutoRepository _ProdutoRepository;
        public UpdateProdutoUseCase(IProdutoRepository ProdutoRepository)
        {
            _ProdutoRepository = ProdutoRepository;
        }

        public UseCaseResponse<int?> Execute(UpdateRequestBase<UpdateProdutoDto> request)
        {
            var response = new UseCaseResponse<int?>();

            try
            {
                if (request == null || request.Id == 0 || request.ModelValue == null)
                    throw new ArgumentNullException(nameof(request));

                _ProdutoRepository.UpdateProduto(request.Id, request.ModelValue!);
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
