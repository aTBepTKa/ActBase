using Microsoft.EntityFrameworkCore;
using ActBase.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActBase.Storage
{
    public class ActBaseContext : DbContext
    {
        public DbSet<Act> Acts { get; set; }
        public DbSet<Material> Materials { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ActBaseDb;Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
