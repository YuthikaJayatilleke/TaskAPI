using Microsoft.EntityFrameworkCore;
using System;
using TaskAPI.Models;

namespace TaskAPI.DataAccess
{
    public class TodoDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var constr = "Server = localhost; Database=MyToodDb;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(constr);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var todo1 = new Todo
            {
                Id = 1,
                Description = "Description 01",
                Titel = "Titel 01",
                Created = System.DateTime.Now,
                Due = System.DateTime.Now.AddDays(4),
                Status = TodoStatus.New
            };
            modelBuilder.Entity<Todo>().HasData(todo1);
        }
    }
}
