using Microsoft.AspNetCore.Mvc;
using Petshop.Borders.Dtos.Repositories.Pet;
using Petshop.Borders.Dtos.UseCase.Common;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Pet;

namespace Petshop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PetController : ControllerBase
    {
        private readonly IUpdatePetUseCase _updatePetUseCase;
        private readonly IGetListPetsUseCase _getListPetsUseCase;
        private readonly IGetPetUseCase _getPetUseCase;
        private readonly ICreatePetUseCase _createPetUseCase;

        public PetController(IUpdatePetUseCase updatePetUseCase, IGetListPetsUseCase getListPetsUseCase, IGetPetUseCase getPetUseCase, ICreatePetUseCase createPetUseCase)
        {
            _updatePetUseCase = updatePetUseCase;
            _getListPetsUseCase = getListPetsUseCase;
            _getPetUseCase = getPetUseCase;
            _createPetUseCase = createPetUseCase;
        }

        [HttpGet]
        public IActionResult GetPets()
        {
            var request = new UseCaseRequest<int>();
            var result = _getListPetsUseCase.Execute(request);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetPet(int id)
        {
            var request = new UseCaseRequest<int>();
            request.RequestValue = id;
            var result = _getPetUseCase.Execute(request);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreatePetDto Pet)
        {
            var request = new UseCaseRequest<CreatePetDto>();
            request.RequestValue = Pet;
            var result = _createPetUseCase.Execute(request);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdatePetDto Pet)
        {
            var request = new UpdateRequestBase<UpdatePetDto>();
            request.ModelValue = Pet;
            request.Id = id;

            var result = _updatePetUseCase.Execute(request);
            if (result == null) return NotFound();
            return Ok(result);
        }
    }
}