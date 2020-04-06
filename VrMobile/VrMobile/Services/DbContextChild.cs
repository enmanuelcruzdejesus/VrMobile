using System;
using Microsoft.EntityFrameworkCore;

namespace VrMobile.DAL.Services
{
    public class DbContextChild: DatabaseContext
    {

        public DbContextChild()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={App.DbPath}");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
