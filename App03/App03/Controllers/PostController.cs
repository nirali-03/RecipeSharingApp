using App03.Data;
using App03.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App03.Controllers
{
    [Route("api/Post/")]
    [EnableCors("corspolicy")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly App03Context _context;

        public PostController(App03Context context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("Post")]
        
        public Post AddUser(Post obj)
        {
           
            _context.Post.Add(obj);
            _context.SaveChanges();

            return obj;

        }
    }
}
