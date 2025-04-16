using Microsoft.EntityFrameworkCore;
using ToDoAppBack.Models;

namespace ToDoAppBack.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ToDo> ToDos { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
