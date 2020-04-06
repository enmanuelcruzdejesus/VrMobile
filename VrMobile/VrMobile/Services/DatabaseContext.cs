using System;
using Microsoft.EntityFrameworkCore;
using VrMobile.Models;

namespace VrMobile.DAL.Services
{
    public class DatabaseContext: DbContext
    {

        private string _dbPath;
        public DbSet<Customers> Customers { get; set; }

        public DatabaseContext() { }

        public DatabaseContext(string dbPath)
        {
            this._dbPath = dbPath;
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>()
           .HasKey(c => c.IdCustomer);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={_dbPath}");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
