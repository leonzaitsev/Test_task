using System;
using Microsoft.EntityFrameworkCore;
using Synevo_test_project.Data.Mappings;
using Synevo_test_project.Entites;

namespace Synevo_test_project.Data
{
    public class AppDBContent : DbContext
    {
        public DbSet<PokemonOrder> PokemonOrders { get; set; }
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {
            //Database.EnsureDeleted();
           // Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PokemonOrderMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
