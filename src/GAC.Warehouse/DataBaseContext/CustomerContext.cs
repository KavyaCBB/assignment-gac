using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IO.Swagger.Models;
using Microsoft.EntityFrameworkCore;

namespace GAC.Warehouse.DataBaseContext
{
  /// <summary>
  /// 
  /// </summary>
  public class CustomerContext : DbContext
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="options"></param>
    public CustomerContext(DbContextOptions<CustomerContext> options)
            : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Customer>().HasData(new Customer
      {
        ID=1,
        Name = "CustomerA",
        EmailID = "uncle@gmail.com",
        PhoneNumber="1234567890"
      }, new Customer
      {
        ID=2,
        Name = "CustomerB",
        EmailID = "bob@gmail.com",
        PhoneNumber = "1234567891"
      });
    }

    /// <summary>
    /// 
    /// </summary>
    public DbSet<Customer> Customers { get; set; }
  }
}
