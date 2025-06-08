using Cats.Data;
using Cats.Models;
using Cats.Models.Domain;
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
        public IActionResult AddCatt(AddCatRequestDTO request)
        {
            var domainModelCat = new Cat
            {

                Id = Guid.NewGuid(),
                Name = request.Name,
                Email = request.Email,
                Phone = request.Phone,
                Favorite = request.Favorite,
            };

            dbContext.Catt.Add(domainModelCat);
            dbContext.SaveChanges();

            return Ok(domainModelCat);
        }

    }
}
