﻿// <auto-generated />
using InventoryAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InventoryAPI.Migrations
{
    [DbContext(typeof(InventoryDetailContext))]
    partial class InventoryDetailContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InventoryAPI.Models.InventoryDetail", b =>
                {
                    b.Property<int>("InventoryDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ExpirationDate")
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Quantity")
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("SKU")
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("InventoryDetailId");

                    b.ToTable("InventoryDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
