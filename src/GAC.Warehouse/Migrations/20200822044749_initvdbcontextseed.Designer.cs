﻿// <auto-generated />
using System;
using GAC.Warehouse.DataBaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GAC.Warehouse.Migrations
{
    [DbContext(typeof(VendorContext))]
    [Migration("20200822044749_initvdbcontextseed")]
    partial class initvdbcontextseed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IO.Swagger.Models.Address", b =>
                {
                    b.Property<int?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("Street")
                        .IsRequired();

                    b.Property<int?>("VendorID")
                        .IsRequired();

                    b.Property<string>("ZipCode")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("VendorID")
                        .IsUnique();

                    b.ToTable("Address");
                });

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

                    b.HasIndex("VendorID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("IO.Swagger.Models.Vendor", b =>
                {
                    b.Property<int?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailID")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<int?>("Rating")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Vendors");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            EmailID = "vendor1@gmail.com",
                            Name = "Vendor1",
                            PhoneNumber = "1234567890",
                            Rating = 9
                        },
                        new
                        {
                            ID = 2,
                            EmailID = "vendor2@gmail.com",
                            Name = "Vendor2",
                            PhoneNumber = "1234567891",
                            Rating = 7
                        });
                });

            modelBuilder.Entity("IO.Swagger.Models.Address", b =>
                {
                    b.HasOne("IO.Swagger.Models.Vendor")
                        .WithOne("Address")
                        .HasForeignKey("IO.Swagger.Models.Address", "VendorID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IO.Swagger.Models.Product", b =>
                {
                    b.HasOne("IO.Swagger.Models.Vendor")
                        .WithMany("products")
                        .HasForeignKey("VendorID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
