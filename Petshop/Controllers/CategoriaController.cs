using Microsoft.AspNetCore.Mvc;
using Petshop.Borders.Dtos.Repositories.Categoria;
using Petshop.Borders.UseCase.Categoria;
using Petshop.Borders.Dtos.UseCase.Categoria;
using Petshop.Borders.Dtos.Repositories.Categoria;
using Petshop.Borders.Dtos.UseCase.Categoria;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Categoria;
using Petshop.Borders.Dtos.Repositories.Cliente;
using Petshop.Entities.EntitiesContext;
using Petshop.Borders.Dtos.UseCase.Common;

namespace Petshop.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController : ControllerBase
    {
        private readonly IGetListCategoriasUseCase _getListCategoriasUseCase;
        private readonly IUpdateCategoriaUseCase _updateCategoriaUseCase;
        private readonly IGetCategoriaUseCase _getCategoriaUseCase;
        private readonly ICreateCategoriaUseCase _createCategoriaUseCase;
        private readonly IDeleteCategoriaUseCase _deleteCategoriaUseCase;

        public CategoriaController(IGetListCategoriasUseCase getListCategoriasUseCase, IUpdateCategoriaUseCase updateCategoriaUseCase, IGetCategoriaUseCase getCategoriaUseCase, ICreateCategoriaUseCase createCategoriaUseCase, IDeleteCategoriaUseCase deleteCategoriaUseCase)
        {
            _getListCategoriasUseCase = getListCategoriasUseCase;
            _updateCategoriaUseCase = updateCategoriaUseCase;
            _getCategoriaUseCase = getCategoriaUseCase;
            _createCategoriaUseCase = createCategoriaUseCase;
            _deleteCategoriaUseCase = deleteCategoriaUseCase;
        }

        [HttpGet]
        public IActionResult GetCategorias()
        {
            var request = new GetListCategoriasRequest(idProduto: 0);
            var result = _getListCategoriasUseCase.Execute(request);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetCategoria(int id)
        {
            var request = new UseCaseRequest<int>();
            request.RequestValue = id;
            var result = _getCategoriaUseCase.Execute(request);
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create(int idPessoa, [FromBody] CreateCategoriaDto Categoria)
        {
            var request = new UseCaseRequest<CreateCategoriaDto>();
            request.RequestValue = Categoria;
            var result = _createCategoriaUseCase.Execute(request);
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateCategoriaDto Categoria)
        {
            var request = new UpdateRequestBase<UpdateCategoriaDto>();
            request.ModelValue = Categoria;
            request.Id = id;
            var result = _updateCategoriaUseCase.Execute(request);
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var request = new UseCaseRequest<int>();
            request.RequestValue = id;
            var result = _deleteCategoriaUseCase.Execute(request);
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }

    }
}