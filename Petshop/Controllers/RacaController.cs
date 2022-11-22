using Microsoft.AspNetCore.Mvc;
using Petshop.Borders.Dtos.Repositories.Categoria;
using Petshop.Borders.UseCase.Categoria;
using Petshop.Borders.Dtos.UseCase.Categoria;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Raca;

namespace Petshop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RacaController : ControllerBase
    {
        private readonly IGetListRacasUseCase _getListRacasUseCase;

        public RacaController(IGetListRacasUseCase getListRacasUseCase)
        {
            _getListRacasUseCase = getListRacasUseCase;
        }

        [HttpGet]
        public IActionResult GetRacas()
        {
            var request = new UseCaseRequest<int>();
            var result = _getListRacasUseCase.Execute(request);
            if (result == null) return NotFound();
            return Ok(result);
        }

    }
}