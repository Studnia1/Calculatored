using Calculatored.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculatored.EntityFramework
{
    public class CalculatoredDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<B2BData> b2BDatas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-IP6R8FT;Database=B2BCalculator;Trusted_Connection=True;");

            base.OnConfiguring(optionsBuilder);
        }
        /*public SimpleTraderDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }*/
    }
}
