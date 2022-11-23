using Microsoft.AspNetCore.Mvc;
using Petshop.Borders.Dtos.Repositories.Servico;
using Petshop.Borders.Dtos.UseCase.Common;
using Petshop.Borders.Dtos.UseCase.Servico;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Servico;

namespace Petshop.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServicoController : ControllerBase
    {
        private readonly IUpdateServicoUseCase _updateServicoUseCase;
        private readonly IGetListServicosUseCase _getListServicosUseCase;
        private readonly IGetServicoUseCase _getServicoUseCase;
        private readonly ICreateServicoUseCase _createServicoUseCase;
        private readonly IDeleteServicoUseCase _deleteServicoUseCase;
        private readonly IAddProdutoUseCase _addProdutoUseCase;

        public ServicoController(IUpdateServicoUseCase updateServicoUseCase, IGetListServicosUseCase getListServicosUseCase, IGetServicoUseCase getServicoUseCase, ICreateServicoUseCase createServicoUseCase, IDeleteServicoUseCase deleteServicoUseCase, IAddProdutoUseCase addProdutoUseCase)
        {
            _updateServicoUseCase = updateServicoUseCase;
            _getListServicosUseCase = getListServicosUseCase;
            _getServicoUseCase = getServicoUseCase;
            _createServicoUseCase = createServicoUseCase;
            _deleteServicoUseCase = deleteServicoUseCase;
            _addProdutoUseCase = addProdutoUseCase;
        }

        [HttpGet]
        public IActionResult GetServicos()
        {
            var request = new UseCaseRequest<int>();
            var result = _getListServicosUseCase.Execute(request);
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetServico(int id)
        {
            var request = new UseCaseRequest<int>();
            request.RequestValue = id;
            var result = _getServicoUseCase.Execute(request);
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateServicoDto Servico)
        {
            var request = new UseCaseRequest<CreateServicoDto>();
            request.RequestValue = Servico;
            var result = _createServicoUseCase.Execute(request);
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateServicoDto Servico)
        {
            var request = new UpdateRequestBase<UpdateServicoDto>();
            request.ModelValue = Servico;
            request.Id = id;

            var result = _updateServicoUseCase.Execute(request);
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }

        [HttpPost]
        [Route("produto/{id}/{idProduto}")]
        public IActionResult AddProduto(int id, int idProduto)
        {
            var request = new UseCaseRequest<AddProdutoRequest>();
            request.RequestValue = new AddProdutoRequest(id, idProduto);
            var result = _addProdutoUseCase.Execute(request);
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var request = new UseCaseRequest<int>();
            request.RequestValue = id;
            var result = _deleteServicoUseCase.Execute(request);
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }
    }
}