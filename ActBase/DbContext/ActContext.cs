using Microsoft.EntityFrameworkCore;
using ActBase.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActBase.DbContext
{
    public class ActContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Act> Acts { get; set; }
        public DbSet<Material> Materials { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ActBaseDb;Trusted_Connection=True;MultipleActiveResultSets=true");
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
    }
}
