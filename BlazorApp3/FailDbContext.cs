using BlazorApp3.Modalss;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp3
{
    public class FailDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public FailDbContext(DbContextOptions<FailDbContext> options) : base (options) {}
    }
}
