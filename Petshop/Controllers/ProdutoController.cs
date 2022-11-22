using Microsoft.AspNetCore.Mvc;
using Petshop.Borders.Dtos.Repositories.Produto;
using Petshop.Borders.Dtos.UseCase.Common;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Endereco;
using Petshop.Borders.UseCase.Produto;
using Petshop.UseCases.Endereco;

namespace Petshop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IUpdateProdutoUseCase _updateProdutoUseCase;
        private readonly IGetListProdutosUseCase _getListProdutosUseCase;
        private readonly IGetProdutoUseCase _getProdutoUseCase;
        private readonly ICreateProdutoUseCase _createProdutoUseCase;
        private readonly IDeleteProdutoUseCase _deleteProdutoUseCase;

        public ProdutoController(IUpdateProdutoUseCase updateProdutoUseCase, IGetListProdutosUseCase getListProdutosUseCase, IGetProdutoUseCase getProdutoUseCase, ICreateProdutoUseCase createProdutoUseCase, IDeleteProdutoUseCase deleteProdutoUseCase)
        {
            _updateProdutoUseCase = updateProdutoUseCase;
            _getListProdutosUseCase = getListProdutosUseCase;
            _getProdutoUseCase = getProdutoUseCase;
            _createProdutoUseCase = createProdutoUseCase;
            _deleteProdutoUseCase = deleteProdutoUseCase;
        }

        [HttpGet]
        public IActionResult GetProdutos()
        {
            var request = new UseCaseRequest<int>();
            var result = _getListProdutosUseCase.Execute(request);
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduto(int id)
        {
            var request = new UseCaseRequest<int>();
            request.RequestValue = id;
            var result = _getProdutoUseCase.Execute(request);
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateProdutoDto Produto)
        {
            var request = new UseCaseRequest<CreateProdutoDto>();
            request.RequestValue = Produto;
            var result = _createProdutoUseCase.Execute(request);
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateProdutoDto Produto)
        {
            var request = new UpdateRequestBase<UpdateProdutoDto>();
            request.ModelValue = Produto;
            request.Id = id;

            var result = _updateProdutoUseCase.Execute(request);
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var request = new UseCaseRequest<int>();
            request.RequestValue = id;
            var result = _deleteProdutoUseCase.Execute(request);
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }
    }
}
