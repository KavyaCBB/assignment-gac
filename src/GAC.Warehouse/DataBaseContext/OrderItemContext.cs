using IO.Swagger.Models;
using Microsoft.EntityFrameworkCore;

namespace GAC.Warehouse.DataBaseContext
{
  public class OrderItemContext :DbContext
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="options"></param>
    public OrderItemContext(DbContextOptions<OrderItemContext> options)
            : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<OrderItem>().HasData(new OrderItem
      {
        ID = 1,
        OrderID = 1,
        ProductID = 1,
        Quantity=12
      },
      new OrderItem
      {
        ID = 2,
        OrderID = 1,
        ProductID = 2,
        Quantity = 1100
      });
    }

    /// <summary>
    /// 
    /// </summary>
    public DbSet<OrderItem> OrderItems { get; set; }
  }
}
