using ForumPart2.Services.Abstractions;
using ForumParts2.Models.CreateModels;
using ForumParts2.Models.UpdateModels;
using ForumParts2.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ForumPart2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService service;

        public CommentController(ICommentService service)
        {
            this.service = service;
        }

        [HttpGet("Id")]
        [ProducesResponseType(typeof(CommentViewModel), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetModel([FromQuery] Guid Id)
        {
            var model = await service.GetByIdAsync(Id);
            return Ok(model);

        }

        [HttpPost]
        [ProducesResponseType(typeof(CommentViewModel), StatusCodes.Status200OK)]
        public async Task<IActionResult> CreateModel([FromBody] CommentCreateModel createModel)
        {
            var model = await service.CreateAsync(createModel);
            return Ok(model);

        }

        [HttpPut]
        [ProducesResponseType(typeof(CommentViewModel), StatusCodes.Status200OK)]
        public async Task<IActionResult> UpdateModel([FromBody] CommentUpdateModel updateModel)
        {
            var model = await service.UpdateAsync(updateModel);
            return Ok(model);

        }

        [HttpDelete("Id")]
        [ProducesResponseType(typeof(CommentViewModel), StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteModel([FromQuery] Guid Id)
        {
            await service.DeleteByIdAsync(Id);
            return Ok();

        }
    }
}
