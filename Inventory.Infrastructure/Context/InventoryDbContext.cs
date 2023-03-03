using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Application.Models;
namespace Inventory.Infrastructure.Context
{
    public class InventoryDbContext : DbContext
    {

        public InventoryDbContext(DbContextOptions<InventoryDbContext> options)
         : base(options)
        {
        }
        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().ToTable("Items");
            modelBuilder.Entity<Item>()
                .HasKey(k => k.Id);
            modelBuilder.Entity<Item>()
                .Property(i => i.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Item>().Property(i => i.Description).HasMaxLength(50);
            modelBuilder.Entity<Item>().Property(i => i.Name).HasMaxLength(30);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public override int SaveChanges()
        {

            var tracker = ChangeTracker;
            foreach (var entry in tracker.Entries())
            {
                if (entry.Entity is FullAuditModel)
                {
                    var referenceEntity = entry.Entity as FullAuditModel;
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            referenceEntity.CreatedDate = DateTime.Now;
                            referenceEntity.CreatedByUserId = "jmayorga"; //ToDo get user
                            referenceEntity.LastModifiedUserId = "jmayorga"; //ToDo get user
                            break;
                        case EntityState.Deleted:
                        case EntityState.Modified:
                            referenceEntity.LastModifiedDate = DateTime.Now;
                            referenceEntity.LastModifiedUserId = "jmayorga"; //ToDo get user
                            break;
                        default:
                            break;
                    }
                }
            }
            return base.SaveChanges();
    }


    }
}
