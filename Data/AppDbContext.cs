using Microsoft.EntityFrameworkCore;
using chris_todolist.Models;

namespace chris_todolist.Data {
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Todo> Todos { get; set; }
    }
}