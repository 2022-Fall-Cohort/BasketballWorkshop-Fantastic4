using CSharpBasketballWorkshop.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace CSharpBasketballWorkshop
{
    public class BasketballContext : DbContext
    {
        public DbSet<Player>? Players { get; set; }
        public DbSet<Team>? Teams { get; set; }
        //public BasketballContext(DbContextOptions<BasketballContext> options) : base(options)
        //{ }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=BasketballDB;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
