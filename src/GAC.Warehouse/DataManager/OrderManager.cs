using GAC.Warehouse.DataBaseContext;
using GAC.Warehouse.Repository;
using IO.Swagger.Models;
using System.Collections.Generic;
using System.Linq;

namespace GAC.Warehouse.DataManager
{
  public class OrderManager : IDataRepository<Order>
  {
    readonly OrderContext _orderContext;

    public OrderManager(OrderContext context)
    {
      _orderContext = context;
    }

    public IEnumerable<Order> GetAll()
    {
      return _orderContext.Orders.ToList();
    }

    public Order Get(long id)
    {
      return _orderContext.Orders.FirstOrDefault(e => e.ID == id);
    }

    public int? Add(Order entity)
    {
      _orderContext.Orders.Add(entity);
      _orderContext.SaveChanges();
      return entity.ID;
    }

    public void Update(Order order, Order entity)
    {
      order.ID = entity.ID;
      order.CustomerID = entity.CustomerID;
      order.OrderDate = entity.OrderDate;
      _orderContext.SaveChanges();
    }

    public void Delete(Order order)
    {
      _orderContext.Orders.Remove(order);
      _orderContext.SaveChanges();
    }
  }
}
