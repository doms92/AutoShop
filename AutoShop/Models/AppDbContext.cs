﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {

        }

        public DbSet<AutoPart> AutoParts { get; set; }
        public DbSet<WorkOrder> workOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<WorkOrder>().HasData(new WorkOrder
            {
                WorkOrderId = 1,
                WorkOrderName =
                "Tire"
            });
            modelBuilder.Entity<WorkOrder>().HasData(new WorkOrder
            {
                WorkOrderId = 2,
                WorkOrderName =
                "Engine"
            });

            modelBuilder.Entity<WorkOrder>().HasData(new WorkOrder
            {
                WorkOrderId = 3,
                WorkOrderName =
                "Alternator"
            });

            modelBuilder.Entity<AutoPart>().HasData(new AutoPart
            {
                AutoPartsId = 1,
                Name = "Pirelli Tires",
                Price = 335.00M,
                Description = "Pirelli, Foreign",
                CategoryId = 1,
                ImageUrl = "\\Images\\pzero.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\pi.jpg",
                IsInStock=true,
                IsOnSale = false
            });
            modelBuilder.Entity<AutoPart>().HasData(new AutoPart
            {
                AutoPartsId = 2,
                Name = "Stock Engine",
                Price = 1000.00M,
                Description = "USA Engine",
                CategoryId = 1,
                ImageUrl = "\\Images\\engine.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\eng.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<AutoPart>().HasData(new AutoPart
            {
                AutoPartsId = 3,
                Name = "Stock Alternator",
                Price = 222.00M,
                Description = "USA Alternator",
                CategoryId = 1,
                ImageUrl = "\\Images\\alternator.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\alt.jpg",
                IsInStock = true,
                IsOnSale = true
            });
        }
    }
}
