using Microsoft.EntityFrameworkCore;
using To_Do_APP.Models;

namespace To_Do_APP.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

       public DbSet<toDoList> ToDoLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<toDoList>().HasData(
                new toDoList { Id = 1, Title = "Project work", IsCompleted = true },
                new toDoList { Id = 2, Title = "Project work 2", IsCompleted = false },
                new toDoList { Id = 3, Title = "Project work 3", IsCompleted = true }
                );
        }

    }
}
