using Microsoft.AspNetCore.Mvc;
using Petshop.Borders.Dtos.Repositories.Funcionario;
using Petshop.Borders.Dtos.UseCase.Common;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Funcionario;
using Petshop.Borders.UseCase.Funcionario;

namespace Petshop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase
    {
        private readonly IUpdateFuncionarioUseCase _updateFuncionarioUseCase;
        private readonly IGetListFuncionariosUseCase _getListFuncionariosUseCase;
        private readonly IGetFuncionarioUseCase _getFuncionarioUseCase;
        private readonly ICreateFuncionarioUseCase _createFuncionarioUseCase;
        private readonly IDeleteFuncionarioUseCase _deleteFuncionarioUseCase;

        public FuncionarioController(IUpdateFuncionarioUseCase updateFuncionarioUseCase, IGetListFuncionariosUseCase getListFuncionariosUseCase, IGetFuncionarioUseCase getFuncionarioUseCase, ICreateFuncionarioUseCase createFuncionarioUseCase, IDeleteFuncionarioUseCase deleteFuncionarioUseCase)
        {
            _updateFuncionarioUseCase = updateFuncionarioUseCase;
            _getListFuncionariosUseCase = getListFuncionariosUseCase;
            _getFuncionarioUseCase = getFuncionarioUseCase;
            _createFuncionarioUseCase = createFuncionarioUseCase;
            _deleteFuncionarioUseCase = deleteFuncionarioUseCase;
        }

        [HttpGet]
        public IActionResult GetFuncionarios()
        {
            var request = new UseCaseRequest<int>();
            var result = _getListFuncionariosUseCase.Execute(request);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetFuncionario(int id)
        {
            var request = new UseCaseRequest<int>();
            request.RequestValue = id;
            var result = _getFuncionarioUseCase.Execute(request);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateFuncionarioDto Funcionario)
        {
            var request = new UseCaseRequest<CreateFuncionarioDto>();
            request.RequestValue = Funcionario;
            var result = _createFuncionarioUseCase.Execute(request);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateFuncionarioDto Funcionario)
        {
            var request = new UpdateRequestBase<UpdateFuncionarioDto>();
            request.ModelValue = Funcionario;
            request.Id = id;

            var result = _updateFuncionarioUseCase.Execute(request);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var request = new UseCaseRequest<int>();
            request.RequestValue = id;
            var result = _deleteFuncionarioUseCase.Execute(request);
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }
    }
}