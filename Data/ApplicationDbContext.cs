using System;
using System.Collections.Generic;
using System.Text;
using Chemical_Inventory_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Chemical_Inventory_Management_System.Models
{
    public class ApplicationDbContext : DbContext
    {

        // db connection

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Chemical> Chemicals { get; set; }
        public DbSet<Batch> Batches { get; set; }
        public DbSet<ShoppingItem> ShoppingItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // if we didnt had any relation 
            //modelBuilder.Entity < Chemical>()
            //    .Property(c => c.Name)
            //    .IsRequired();


            modelBuilder.Entity<Batch>()
                 .HasOne(b => b.Chemical)
                 .WithMany(c => c.Batches)
                 .HasForeignKey(b => b.chemicalId);
        }

    }


}