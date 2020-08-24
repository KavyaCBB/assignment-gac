using IO.Swagger.Models;
using Microsoft.EntityFrameworkCore;

namespace GAC.Warehouse.DataBaseContext
{
  public class OrderContext  :DbContext
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="options"></param>
    public OrderContext(DbContextOptions<OrderContext> options)
            : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Order>().HasData(new Order
      {
        ID = 1,
        CustomerID = 1,
        OrderDate = "10/08/2020",
      });
    }

    /// <summary>
    /// 
    /// </summary>
    public DbSet<Order> Orders { get; set; }
  }
}
