using Microsoft.AspNetCore.Mvc;
using Petshop.Borders.Dtos.Repositories.Fornecedores;
using Petshop.Borders.Dtos.UseCase.Common;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Endereco;
using Petshop.Borders.UseCase.Fornecedores;
using Petshop.UseCases.Endereco;

namespace Petshop.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FornecedorController : ControllerBase
    {
        private readonly IUpdateFornecedoresUseCase _updateFornecedorUseCase;
        private readonly IGetListFornecedoresUseCase _getListFornecedoresUseCase;
        private readonly IGetFornecedorUseCase _getFornecedorUseCase;
        private readonly ICreateFornecedorUseCase _createFornecedorUseCase;
        private readonly IDeleteFornecedorUseCase _deleteFornecedorUseCase;

        public FornecedorController(IUpdateFornecedoresUseCase updateFornecedorUseCase, IGetListFornecedoresUseCase getListFornecedoresUseCase, IGetFornecedorUseCase getFornecedorUseCase, ICreateFornecedorUseCase createFornecedorUseCase, IDeleteFornecedorUseCase deleteFornecedorUseCase)
        {
            _updateFornecedorUseCase = updateFornecedorUseCase;
            _getListFornecedoresUseCase = getListFornecedoresUseCase;
            _getFornecedorUseCase = getFornecedorUseCase;
            _createFornecedorUseCase = createFornecedorUseCase;
            _deleteFornecedorUseCase = deleteFornecedorUseCase;
        }

        [HttpGet]
        public IActionResult GetFornecedores()
        {
            var request = new UseCaseRequest<int>();
            var result = _getListFornecedoresUseCase.Execute(request);
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetFornecedor(int id)
        {
            var request = new UseCaseRequest<int>();
            request.RequestValue = id;
            var result = _getFornecedorUseCase.Execute(request);
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateFornecedorDto Fornecedor)
        {
            var request = new UseCaseRequest<CreateFornecedorDto>();
            request.RequestValue = Fornecedor;
            var result = _createFornecedorUseCase.Execute(request);
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateFornecedorDto Fornecedor)
        {
            var request = new UpdateRequestBase<UpdateFornecedorDto>();
            request.ModelValue = Fornecedor;
            request.Id = id;

            var result = _updateFornecedorUseCase.Execute(request);
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var request = new UseCaseRequest<int>();
            request.RequestValue = id;
            var result = _deleteFornecedorUseCase.Execute(request);
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }
    }
}
