using Microsoft.EntityFrameworkCore;
using TaskSystem.Models;

namespace TaskSystem.Data
{
    public class SystemTasksDBContext : DbContext
    {
        public SystemTasksDBContext(DbContextOptions<SystemTasksDBContext> options) : base(options) { }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<TaskModel> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
