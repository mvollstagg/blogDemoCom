using Data.Domain;
using Data.Mapping;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=blogdemo.mssql.somee.com;Database=blogdemo;User Id=mvollstagg_SQLLogin_1;Password=jeo92ieqz9;MultipleActiveResultSets=true");
        }
        public DataContext()
        {
        }
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Post> Post { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PostMapping());
            modelBuilder.ApplyConfiguration(new UserMapping());
        }
    }
}