using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using streachBackend.Services.WebPost;
using streachBackend.Web.Serialization;
using streachBackend.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace streachBackend.Web.Controllers
{
    [ApiController]
    public class WebPostsController : ControllerBase
        {
        private readonly ILogger<WebPostsController> _logger;
        private readonly IWebpost _webpostService;
        public WebPostsController(

            ILogger<WebPostsController> logger, IWebpost webpostService)
        {
            _logger = logger;
            _webpostService = webpostService;
        }

            [HttpGet("/api/post")]
            public ActionResult GetPost(){
            _logger.LogInformation("Getting all posts");
           var posts =  _webpostService.GetAllPosts();
            var PostViewModels = posts.Select(PostMapper.SerializePostModel);
            return Ok(PostViewModels);
            }

            [HttpPost("/api/post")]
            public ActionResult GenerateNewPost([FromBody]PostModel post)
            {
            _logger.LogInformation("Generating new Post");
            var newPost = PostMapper.SerializePostModel(post);
            var newPostResponse = _webpostService.CreatePost(newPost);
            return Ok(newPost);
            }

        }
}
