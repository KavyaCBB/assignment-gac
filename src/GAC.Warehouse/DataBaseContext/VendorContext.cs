using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IO.Swagger.Models;
using Microsoft.EntityFrameworkCore;

namespace GAC.Warehouse.DataBaseContext
{
  public class VendorContext  :DbContext
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="options"></param>
    public VendorContext(DbContextOptions<VendorContext> options)
            : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      //List<Product> productlist1 = new List<Product>();
      //List<Product> productlist2 = new List<Product>();
      //productlist1.Add(new Product() { ID = 1, Code = "C122", VendorID = 1, Description = "test", Dimension = "12*7", Name = "P1" });
      //productlist1.Add(new Product() { ID = 2, Code = "C123", VendorID = 1, Description = "test1", Dimension = "12*8", Name = "P2" }); ;
      //productlist2.Add(new Product() { ID = 3, Code = "C124", VendorID = 2, Description = "test2", Dimension = "12*9", Name = "P3" }); ;
      //productlist2.Add(new Product() { ID = 4, Code = "C125", VendorID = 2, Description = "test3", Dimension = "12*10", Name = "P4" }); ;
      //Address address1 = new Address();
      //Address address2 = new Address();
      //address1 = new Address() { ID = 1, City = "Bangalore", Country = "India",VendorID=1, State = "Karnataka", Street = "Triveni Road", ZipCode = "560021" };
      //address2 = new Address() { ID = 2, City = "Hyderabad", Country = "India", VendorID = 2, State = "Andhra", Street = "Cord Road", ZipCode = "121212" };
      modelBuilder.Entity<Vendor>().HasData(new Vendor
      {
        ID = 1,
        Name = "Vendor1",
        EmailID = "vendor1@gmail.com",
        PhoneNumber = "1234567890",
        Rating = 9
      }, new Vendor
      {
        ID = 2,
        Name = "Vendor2",
        EmailID = "vendor2@gmail.com",
        PhoneNumber = "1234567891",
        Rating = 7
      });
    }

    /// <summary>
    /// 
    /// </summary>
    public DbSet<Vendor> Vendors { get; set; }
  }
}
