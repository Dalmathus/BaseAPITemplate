using Microsoft.AspNetCore.Mvc;
using BaseAPITemplate.Contracts.Example;

namespace BaseAPITemplate.Controllers
{
    [ApiController]
    public class EntityController : ControllerBase
    {

        [HttpPost("/entity")]
        public IActionResult CreateEntity(CreateEntityRequest request)
        {
            return Ok(request);
        }

        [HttpGet("/entity/{id:guid}")]
        public IActionResult GetEntity(Guid id)
        {
            return Ok(id);
        }

        [HttpPut("/entity/{id:guid}")]
        public IActionResult UpsertEntity(Guid id, UpsertEntityRequest request)
        {
            return Ok(request);
        }

        [HttpDelete("/entity/{id:guid}")]
        public IActionResult DeleteEntity(Guid id)
        {
            return Ok(id);
        }
    } 
}
