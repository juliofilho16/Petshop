using Microsoft.AspNetCore.Mvc;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Cidade;

namespace Petshop.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CidadeController : ControllerBase
    {
       private readonly IGetListCidadesUseCase _getListCidadesUseCase;

        public CidadeController(IGetListCidadesUseCase getListCidadesUseCase)
        {
            _getListCidadesUseCase = getListCidadesUseCase;
        }

        [HttpGet]
        public IActionResult GetCidades()
        {
            var request = new UseCaseRequest<int>();
            var result = _getListCidadesUseCase.Execute(request);
            if (result == null) return NotFound();
            return Ok(result);
        }

    }
}