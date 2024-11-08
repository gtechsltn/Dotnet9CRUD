using Dotnet9CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace Dotnet9CRUD.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Category> Category { get; set; }
    }
}
