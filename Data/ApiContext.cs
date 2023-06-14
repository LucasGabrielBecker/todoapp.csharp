using Microsoft.EntityFrameworkCore;
using TodoApp.Models;

namespace TodoApp.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {

        }

    }
}
