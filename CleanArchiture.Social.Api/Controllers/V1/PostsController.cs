using CleanArchitecture.Social.Domain.Models;

namespace CleanArchitecture.Social.Api.Controllers.V1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class PostsController : ControllerBase
    {
        [HttpGet("getbyid/{id}")]
        public IActionResult GetById(string id)
        {
            var post = new Post
            {
                Id = id,
                Text = "Api version 1"
            };

            return Ok(post);
        }

    }
}
