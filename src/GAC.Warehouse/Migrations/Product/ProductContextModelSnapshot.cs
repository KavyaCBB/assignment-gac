﻿// <auto-generated />
using System;
using GAC.Warehouse.DataBaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GAC.Warehouse.Migrations.Product
{
    [DbContext(typeof(ProductContext))]
    partial class ProductContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IO.Swagger.Models.Product", b =>
                {
                    b.Property<int?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Dimension")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("VendorID")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Code = "C122",
                            Description = "test",
                            Dimension = "12*7",
                            Name = "P1",
                            VendorID = 1
                        },
                        new
                        {
                            ID = 2,
                            Code = "C123",
                            Description = "test1",
                            Dimension = "12*8",
                            Name = "P2",
                            VendorID = 1
                        },
                        new
                        {
                            ID = 3,
                            Code = "C124",
                            Description = "test2",
                            Dimension = "12*9",
                            Name = "P3",
                            VendorID = 2
                        },
                        new
                        {
                            ID = 4,
                            Code = "C125",
                            Description = "test3",
                            Dimension = "12*10",
                            Name = "P4",
                            VendorID = 2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
