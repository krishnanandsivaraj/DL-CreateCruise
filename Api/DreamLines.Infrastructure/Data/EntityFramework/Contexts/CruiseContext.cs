using DreamLines.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DreamLines.Infrastructure.Data.EntityFramework.Contexts
{
    public class CruiseContext : DbContext
    {
        public DbSet<CruiseLine> cruiseLines { get; set; }
        public DbSet<Ship> ships { get; set; }

        public DbSet<Port> ports { get; set; }

        public DbSet<Cabintype> cabinTypes { get; set; }

        public DbSet<Cruise> cruise { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=DreamLines;Trusted_Connection=True;");
        }
    }
}
