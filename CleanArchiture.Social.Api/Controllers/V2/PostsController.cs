using CleanArchitecture.Social.Domain.Models;

namespace CleanArchitecture.Social.Api.Controllers.V2
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("2.0")]
    public class PostsController : ControllerBase
    {
        [Route("getbyid/{id}")]
        [HttpGet]
        public IActionResult GetById(string id)
        {
            var post = new Post
            {
                Id = id,
                Text = "api version 2"
            };

            return Ok(post);
        }
    }
}