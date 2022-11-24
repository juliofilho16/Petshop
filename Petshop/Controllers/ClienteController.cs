using Microsoft.AspNetCore.Mvc;
using Petshop.Borders.Dtos.Repositories.Cliente;
using Petshop.Borders.Dtos.UseCase.Common;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Cidade;
using Petshop.Borders.UseCase.Cliente;
using Petshop.Borders.UseCase.Cliente;

namespace Petshop.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IUpdateClienteUseCase _updateClienteUseCase;
        private readonly IGetListClientesUseCase _getListClientesUseCase;
        private readonly IGetClienteUseCase _getClienteUseCase;
        private readonly ICreateClienteUseCase _createClienteUseCase;
        private readonly IDeleteClienteUseCase _deleteClienteUseCase;

        public ClienteController(IUpdateClienteUseCase updateClienteUseCase, IGetListClientesUseCase getListClientesUseCase, IGetClienteUseCase getClienteUseCase, ICreateClienteUseCase createClienteUseCase, IDeleteClienteUseCase deleteClienteUseCase)
        {
            _updateClienteUseCase = updateClienteUseCase;
            _getListClientesUseCase = getListClientesUseCase;
            _getClienteUseCase = getClienteUseCase;
            _createClienteUseCase = createClienteUseCase;
            _deleteClienteUseCase = deleteClienteUseCase;
        }

        [HttpGet]
        public IActionResult GetClientes()
        {
            var request = new UseCaseRequest<int>();
            var result = _getListClientesUseCase.Execute(request);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetCliente(int id)
        {
            var request = new UseCaseRequest<int>();
            request.RequestValue = id;
            var result = _getClienteUseCase.Execute(request);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateClienteDto cliente)
        {
            var request = new UseCaseRequest<CreateClienteDto>();
            request.RequestValue = cliente;
            var result = _createClienteUseCase.Execute(request);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateClienteDto cliente)
        {
            var request = new UpdateRequestBase<UpdateClienteDto>();
            request.ModelValue = cliente;
            request.Id = id;

            var result = _updateClienteUseCase.Execute(request);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var request = new UseCaseRequest<int>();
            request.RequestValue = id;
            var result = _deleteClienteUseCase.Execute(request);
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }
    }
}