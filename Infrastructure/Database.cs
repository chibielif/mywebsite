using My_Website.Models;
using MySql.Data.MySqlClient;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace My_Website.Infrastructure
{
    public class Database : DbContext
    {
        private readonly string _connectionString;

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Comment> Comments { get; set; }


        public Database(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("Default");
        }

        public IDbConnection CreateConnection()
        {
            return new MySqlConnection(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Comment>()
                .HasOne(c => c.BlogPost)
                .WithMany()
                .HasForeignKey(c => c.postId);
        }
    }
}
