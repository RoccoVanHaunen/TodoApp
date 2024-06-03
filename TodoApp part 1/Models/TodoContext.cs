using Microsoft.EntityFrameworkCore;

namespace TodoApp_part_1.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

        public DbSet<TodoListModel> TodoItems { get; set; }
    }
}
