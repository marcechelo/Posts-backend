using Microsoft.AspNetCore.Mvc;
using Posts2.Models;
using Posts2.Data;
using System.Collections.Generic;

namespace Posts2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly PostInterface _repository;
        public PostsController(PostInterface respository)
        {
            _repository = respository;
        }
      
        [HttpGet]
        public ActionResult<IEnumerable<Posts>> getAllPosts()
        {
            var postsItems = _repository.GetPosts();

            return Ok(postsItems);
        }

        [HttpGet("{id}")]
        public ActionResult<Posts> getPost(int id)
        {
            var post = _repository.GetPosts2ById(id);
            return Ok(post);
        }
    }
}
