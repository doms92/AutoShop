﻿// <auto-generated />
using System;
using AutoShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AutoShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210615024131_SeedingDb")]
    partial class SeedingDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AutoShop.Models.AutoPart", b =>
                {
                    b.Property<int>("AutoPartsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("WorkOrdersWorkOrderId")
                        .HasColumnType("int");

                    b.HasKey("AutoPartsId");

                    b.HasIndex("WorkOrdersWorkOrderId");

                    b.ToTable("AutoParts");

                    b.HasData(
                        new
                        {
                            AutoPartsId = 1,
                            CategoryId = 1,
                            Description = "Pirelli, Foreign",
                            ImageThumbnailUrl = "",
                            ImageUrl = "`\\images\\pzero.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Pirelli Tires",
                            Price = 4.95m
                        },
                        new
                        {
                            AutoPartsId = 2,
                            CategoryId = 1,
                            Description = "USA Engine",
                            ImageThumbnailUrl = "",
                            ImageUrl = "`\\images\\engine.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Stock Engine",
                            Price = 4.95m
                        },
                        new
                        {
                            AutoPartsId = 3,
                            CategoryId = 1,
                            Description = "USA Alternator",
                            ImageThumbnailUrl = "",
                            ImageUrl = "`\\images\\alternator.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Stock Alternator",
                            Price = 4.95m
                        });
                });

            modelBuilder.Entity("AutoShop.Models.WorkOrder", b =>
                {
                    b.Property<int>("WorkOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("WorkOrderDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkOrderName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorkOrderId");

                    b.ToTable("workOrders");

                    b.HasData(
                        new
                        {
                            WorkOrderId = 1,
                            WorkOrderName = "Tire"
                        },
                        new
                        {
                            WorkOrderId = 2,
                            WorkOrderName = "Engine"
                        },
                        new
                        {
                            WorkOrderId = 3,
                            WorkOrderName = "Alternator"
                        });
                });

            modelBuilder.Entity("AutoShop.Models.AutoPart", b =>
                {
                    b.HasOne("AutoShop.Models.WorkOrder", "WorkOrders")
                        .WithMany("AutoParts")
                        .HasForeignKey("WorkOrdersWorkOrderId");
                });
#pragma warning restore 612, 618
        }
    }
}