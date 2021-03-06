// <auto-generated />
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
    [Migration("20210615004240_InitialMigration")]
    partial class InitialMigration
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
