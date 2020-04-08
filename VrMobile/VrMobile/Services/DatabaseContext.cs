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

            modelBuilder.Entity<Products>()
           .HasKey(p => p.IdProduct);

            modelBuilder.Entity<Invoices>()
            .HasKey(i => i.IdInvoice);

            modelBuilder.Entity<InvoiceDetails>()
            .HasKey(d => d.Id);

            modelBuilder.Entity<DeliveryOrders>()
            .HasKey(delivery => delivery.IdDeliveryOrder);

            modelBuilder.Entity<VendorVisits>()
          .HasKey(v => v.IdVendorVisit);

            modelBuilder.Entity<SalesOrders>()
            .HasKey(o => o.IdOrder);

            modelBuilder.Entity<SalesOrdersDetail>()
           .HasKey(d => d.Id);

            modelBuilder.Entity<Payments>()
            .HasKey(p => p.IdPayment);


            modelBuilder.Entity<SalesOrdersDetail>().HasOne(d => d.Order).WithMany(o => o.Detail);




        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={_dbPath}");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
