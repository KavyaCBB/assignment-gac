﻿// <auto-generated />
using System;
using GAC.Warehouse.DataBaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GAC.Warehouse.Migrations.Address
{
    [DbContext(typeof(AddressContext))]
    partial class AddressContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            City = "Bangalore",
                            Country = "India",
                            State = "Karnataka",
                            Street = "Triveni Road",
                            VendorID = 1,
                            ZipCode = "560021"
                        },
                        new
                        {
                            ID = 2,
                            City = "Hyderabad",
                            Country = "India",
                            State = "Andhra",
                            Street = "Cord Road",
                            VendorID = 2,
                            ZipCode = "121212"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
