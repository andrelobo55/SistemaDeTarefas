using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Models;


namespace SistemaDeTarefas.Data
{
    public class TaskSystemDbContext : DbContext
    {
        public TaskSystemDbContext(DbContextOptions<TaskSystemDbContext> options) : base(options) {}
        public DbSet<UserModel> Users { get; set; }
        public DbSet<TaskModel> Tasks { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
        }
    }
}