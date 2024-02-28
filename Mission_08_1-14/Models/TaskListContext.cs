using Microsoft.EntityFrameworkCore;

namespace Mission_08_1_14.Models {
    public class TaskListContext : DbContext {
        public TaskListContext(DbContextOptions<TaskListContext> options) : base(options) { }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }

        // Default options: Home, School, Work, Church
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Category>().HasData(
                // Our default categories (seed the data). If no categories are in the table, we add these by default
                new Category { CategoryId = 1, CategoryName = "Home" },
                new Category { CategoryId = 2, CategoryName = "School" },
                new Category { CategoryId = 3, CategoryName = "Work" },
                new Category { CategoryId = 4, CategoryName = "Church" }
            );
        }
    }
}
