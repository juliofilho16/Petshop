using Microsoft.AspNetCore.Mvc;
using Petshop.Borders.Dtos.Repositories.Endereco;
using Petshop.Borders.Dtos.UseCase.Endereco;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Endereco;

namespace Petshop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {
        private readonly IUpdateEnderecoUseCase _updateEnderecoUseCase;
        private readonly IGetListEnderecosUseCase _getListEnderecosUseCase;
        private readonly IGetEnderecoUseCase _getEnderecoUseCase;
        private readonly ICreateEnderecoUseCase _createEnderecoUseCase;
        private readonly IDeleteEnderecoUseCase _deleteEnderecoUseCase;

        public EnderecoController(IUpdateEnderecoUseCase updateEnderecoUseCase, IGetListEnderecosUseCase getListEnderecosUseCase, IGetEnderecoUseCase getEnderecoUseCase, ICreateEnderecoUseCase createEnderecoUseCase, IDeleteEnderecoUseCase deleteEnderecoUseCase)
        {
            _updateEnderecoUseCase = updateEnderecoUseCase;
            _getListEnderecosUseCase = getListEnderecosUseCase;
            _getEnderecoUseCase = getEnderecoUseCase;
            _createEnderecoUseCase = createEnderecoUseCase;
            _deleteEnderecoUseCase = deleteEnderecoUseCase;
        }

        [HttpGet]
        [Route("EnderecosPessoa/{idPessoa}")]
        public IActionResult GetEnderecosPessoa(int idPessoa)
        {
            var request = new UseCaseRequest<int>();
            request.RequestValue = idPessoa;
            var result = _getListEnderecosUseCase.Execute(request);
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetEndereco(int id)
        {
            var request = new UseCaseRequest<int>();
            request.RequestValue = id;
            var result = _getEnderecoUseCase.Execute(request);
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create(int idPessoa, [FromBody] CreateEnderecoDto endereco)
        {
            var result = _createEnderecoUseCase.Execute(new CreateEnderecoRequest(idPessoa: idPessoa, createEnderecoDto: endereco));
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateEnderecoDto endereco)
        {
            var result = _updateEnderecoUseCase.Execute(new UpdateEnderecoRequest(id: id, updateEnderecoDto: endereco));
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var request = new UseCaseRequest<int>();
            request.RequestValue = id;
            var result = _deleteEnderecoUseCase.Execute(request);
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }
    }
}