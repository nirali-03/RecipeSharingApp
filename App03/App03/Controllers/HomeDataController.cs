using App03.Data;
using App03.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Versioning;
using System;

namespace App03.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeDataController : ControllerBase
    {
        private readonly App03Context _context;

        public HomeDataController(App03Context context)
        {
            _context = context;
        }
        
        [HttpGet]
        [ActionName("GetRecies")]
        public async Task<ActionResult<IEnumerable<Post>>> GetRecies()
        {
            var Recipes = await _context.Post.ToListAsync();
            return Ok(Recipes);
        }

        [HttpGet("{category}")]
        [ActionName("GetRecipesByC")]
        public async Task<ActionResult<IEnumerable<Post>>> GetRecipesByC(string category)
        {
            return _context.Post.Where(t => t.category == category).ToList();
        }
    

    }
}
