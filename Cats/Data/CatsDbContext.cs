using Cats.Models.Domain;
using Microsoft.EntityFrameworkCore;
//00012876
namespace Cats.Data
{
    public class CatsDbContext : DbContext
    {
        public CatsDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cat> Catt { get; set; }
    }
}
