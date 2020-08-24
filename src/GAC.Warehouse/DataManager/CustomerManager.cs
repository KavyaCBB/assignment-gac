using GAC.Warehouse.DataBaseContext;
using GAC.Warehouse.Repository;
using IO.Swagger.Models;
using System.Collections.Generic;
using System.Linq;

namespace GAC.Warehouse.DataManager
{
  public class CustomerManager : IDataRepository<Customer>
  {
    readonly CustomerContext _customerContext;

    public CustomerManager(CustomerContext context)
    {
      _customerContext = context;
    }

    public IEnumerable<Customer> GetAll()
    {
      return _customerContext.Customers.ToList();
    }

    public Customer Get(long id)
    {
      return _customerContext.Customers.FirstOrDefault(e => e.ID == id);
    }

    public int? Add(Customer entity)
    {
      _customerContext.Customers.Add(entity);
      _customerContext.SaveChanges();
      return entity.ID;
    }

    public void Update(Customer customer, Customer entity)
    {
      customer.ID = entity.ID;
      customer.Name = entity.Name;
      customer.PhoneNumber = entity.PhoneNumber;
      customer.EmailID = entity.EmailID;

      _customerContext.SaveChanges();
    }

    public void Delete(Customer customer)
    {
      _customerContext.Customers.Remove(customer);
      _customerContext.SaveChanges();
    }
  }
}
