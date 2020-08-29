using Microsoft.EntityFrameworkCore;
using RestApiModeloDDD.Domain.Entities;
using System;
using System.Linq;

namespace RestApiModeloDDD.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext() { }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<Client> Client { get; set; }
        public DbSet<Product> Product { get; set; }
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("CreateAt") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("CreateAt").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("CreateAt").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
