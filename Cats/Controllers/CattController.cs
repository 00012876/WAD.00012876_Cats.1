using Cats.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cats.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CattController : ControllerBase
    {
        private readonly CatsDbContext dbContext;

        public CattController(CatsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllCatt() 
        {
            var catt = dbContext.Catt.ToList();
            return Ok(catt);
        }

        [HttpPost]
        public IActionResult AddCatt()
        {

        }

    }
}
