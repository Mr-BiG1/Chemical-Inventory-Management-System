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

        public DbSet<Batch> Batches { get; set; }
        public DbSet<Chemical> chemicals { get; set; }
        public DbSet<ShoppingItem> shoppingItems { get; set; }      

    }


}