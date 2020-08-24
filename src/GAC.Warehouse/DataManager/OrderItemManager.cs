using GAC.Warehouse.DataBaseContext;
using GAC.Warehouse.Repository;
using IO.Swagger.Models;
using System.Collections.Generic;
using System.Linq;

namespace GAC.Warehouse.DataManager
{
  public class OrderItemManager : IDataRepository<OrderItem>
  {
    readonly OrderItemContext _orderItemContext;

    public OrderItemManager(OrderItemContext context)
    {
      _orderItemContext = context;
    }

    public IEnumerable<OrderItem> GetAll()
    {
      return _orderItemContext.OrderItems.ToList();
    }

    public OrderItem Get(long id)
    {
      return _orderItemContext.OrderItems.FirstOrDefault(e => e.ID == id);
    }

    public int? Add(OrderItem entity)
    {
      _orderItemContext.OrderItems.Add(entity);
      _orderItemContext.SaveChanges();
      return entity.ID;
    }

    public void Update(OrderItem orderItem, OrderItem entity)
    {
      orderItem.ID = entity.ID;
      orderItem.ProductID = entity.ProductID;
      orderItem.Quantity = entity.Quantity;
      //orderItem.OrderRefId = entity.OrderRefId;
      _orderItemContext.SaveChanges();
    }

    public void Delete(OrderItem orderItem)
    {
      _orderItemContext.OrderItems.Remove(orderItem);
      _orderItemContext.SaveChanges();
    }
  }
}
