using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using GroupCW.models;

namespace GroupCW.data
{
    public class MyBloggingApp
    {
        public DbSet<User>? Users { get; set; }
        public DbSet<Blog>? Blogs { get; set; }
        public DbSet<Comment>? Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=bloggingapp.db");
        }
    }
} 