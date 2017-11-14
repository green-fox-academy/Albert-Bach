using FoxManager.Models;
using Microsoft.EntityFrameworkCore;

namespace FoxManager.Entities
{
    public class FoxManagerContext : DbContext

    {
        public FoxManagerContext(DbContextOptions<FoxManagerContext> options) : base(options)
        {
        }

        public DbSet<Class> Classes { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}