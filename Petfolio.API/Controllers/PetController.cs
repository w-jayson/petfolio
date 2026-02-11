
using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCases.Pets.Register;
using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PetController : ControllerBase
    {
       [HttpPost]
       [ProducesResponseType(typeof(ResponseRegisterPetJson), StatusCodes.Status201Created)]
       public IActionResult Register([FromBody] RequestRegisterPetJson request)
        {
            var response = new RegisterPetUseCase().Execute(request);

            return Created(string.Empty, response);
        } 
    }
}