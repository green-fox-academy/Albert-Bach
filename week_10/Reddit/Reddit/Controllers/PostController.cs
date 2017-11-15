using Microsoft.AspNetCore.Mvc;
using Reddit.Models;
using Reddit.Repositories;
using System.Collections.Generic;

namespace Reddit.Controllers
{
    public class PostController : Controller
    {
        PostRepository PostRepository;

        public PostController(PostRepository postRepository)
        {
            PostRepository = postRepository;
        }

        [HttpGet]
        [Route("/posts")]
        public IEnumerable<Post> ListPosts()
        {
            return PostRepository.ListPosts();
        }

        [HttpPost]
        [Route("/posts")]
        public IActionResult AddNewPost([FromBody]Post post)
        {
            PostRepository.AddNewPost(post);
            return Json(post);
        }
        [HttpPut("/posts/{id}/upvote")]
        public IActionResult UpVote(long id)
        {
            PostRepository.UpVote(id);
            return Json(PostRepository.GetPostById(id));
        }

        [HttpPut("/posts/{id}/downvote")]
        public IActionResult DownVote(long id)
        {
            PostRepository.DownVote(id);
            return Json(PostRepository.GetPostById(id));
        }

        [HttpDelete("/posts/{id}/delete")]
        public void Delete(long id)
        {
            PostRepository.Delete(id);
        }

        [HttpPut("/posts/{id}")]
        public IActionResult UpdateTitle(long id, [FromBody] Post post)
        {
            PostRepository.UpdateTitle(id, post);
            return Json(post);
        }
    }
}