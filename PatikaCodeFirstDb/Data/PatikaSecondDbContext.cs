using Microsoft.EntityFrameworkCore;
using PatikaCodeFirstDb.Data.Entities;

namespace PatikaCodeFirstDb.Data
{
    public class PatikaSecondDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
            @"Server=.\SQLEXPRESS;Database=PatikaCodeFirstDb2;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=False"
            );
        }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasOne(p=>p.User).WithMany(u => u.Posts)
                .HasForeignKey(p => p.UserId);
        }
    }
    }

