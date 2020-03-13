using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Framework_Core.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { 
                    id = "1",
                    email = "test@test.com",
                    password = "test",
                    username = "test1"
                },
                new User
                {
                    id = "2",
                    email = "john@doe.com",
                    password = "jhonny",
                    username = "john"
                }
                );
        }
    }
}
