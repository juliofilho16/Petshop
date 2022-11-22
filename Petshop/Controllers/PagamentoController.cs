using Microsoft.AspNetCore.Mvc;
using Petshop.Borders.Dtos.Repositories.Pagamento;
using Petshop.Borders.Dtos.UseCase.Common;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Endereco;
using Petshop.Borders.UseCase.Pagamento;
using Petshop.UseCases.Endereco;

namespace Petshop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PagamentoController : ControllerBase
    {
        private readonly IUpdatePagamentoUseCase _updatePagamentoUseCase;
        private readonly IGetListPagamentosUseCase _getListPagamentosUseCase;
        private readonly ICreatePagamentoUseCase _createPagamentoUseCase;
        private readonly IDeletePagamentoUseCase _deletePagamentoUseCase;

        public PagamentoController(IUpdatePagamentoUseCase updatePagamentoUseCase, IGetListPagamentosUseCase getListPagamentosUseCase, ICreatePagamentoUseCase createPagamentoUseCase, IDeletePagamentoUseCase deletePagamentoUseCase)
        {
            _updatePagamentoUseCase = updatePagamentoUseCase;
            _getListPagamentosUseCase = getListPagamentosUseCase;
            _createPagamentoUseCase = createPagamentoUseCase;
            _deletePagamentoUseCase = deletePagamentoUseCase;
        }

        [HttpGet]
        public IActionResult GetPagamentos(int IdServico)
        {
            var request = new UseCaseRequest<int>();
            request.RequestValue = IdServico;
            var result = _getListPagamentosUseCase.Execute(request);
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreatePagamentoDto Pagamento)
        {
            var request = new UseCaseRequest<CreatePagamentoDto>();
            request.RequestValue = Pagamento;
            var result = _createPagamentoUseCase.Execute(request);
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdatePagamentoDto Pagamento)
        {
            var request = new UpdateRequestBase<UpdatePagamentoDto>();
            request.ModelValue = Pagamento;
            request.Id = id;

            var result = _updatePagamentoUseCase.Execute(request);
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var request = new UseCaseRequest<int>();
            request.RequestValue = id;
            var result = _deletePagamentoUseCase.Execute(request);
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }
    }
}
