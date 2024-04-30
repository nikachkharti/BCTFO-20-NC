using Microsoft.EntityFrameworkCore;
using Todo.Entities;

namespace Todo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedTodos();
        }

        public DbSet<TodoEntity> Todos { get; set; }
    }
}
