using Microsoft.AspNetCore.Mvc;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Especie;

namespace Petshop.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EspecieController : ControllerBase
    {
        private readonly IGetListEspeciesUseCase _getListEspeciesUseCase;

        public EspecieController(IGetListEspeciesUseCase getListEspeciesUseCase)
        {
            _getListEspeciesUseCase = getListEspeciesUseCase;
        }

        [HttpGet]
        public IActionResult GetEspecies()
        {
            var request = new UseCaseRequest<int>();
            var result = _getListEspeciesUseCase.Execute(request);
            if (result == null) return NotFound();
            return Ok(result);
        }

    }
}