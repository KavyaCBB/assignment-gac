using GAC.Warehouse.DataBaseContext;
using GAC.Warehouse.Repository;
using IO.Swagger.Models;
using System.Collections.Generic;
using System.Linq;

namespace GAC.Warehouse.DataManager
{
  public class AddressManager : IDataRepository<Address>
  {
    readonly AddressContext _addressContext;

    public AddressManager(AddressContext context)
    {
      _addressContext = context;
    }

    public IEnumerable<Address> GetAll()
    {
      return _addressContext.Addresses.ToList();
    }

    public Address Get(long id)
    {
      return _addressContext.Addresses.FirstOrDefault(e => e.ID == id);
    }

    public int? Add(Address  entity)
    {
      _addressContext.Addresses.Add(entity);
      _addressContext.SaveChanges();
      return entity.ID;
    }

    public void Update(Address address, Address entity)
    {
      address.ID = entity.ID;
      address.Street = entity.Street;
      address.City = entity.City;
      address.State = entity.State;
      address.Country = entity.Country;
      address.ZipCode = entity.ZipCode;
      //address.VendorRefId=entity.VendorRefId;
      _addressContext.SaveChanges();
    }

    public void Delete(Address address)
    {
      _addressContext.Addresses.Remove(address);
      _addressContext.SaveChanges();
    }
  }
}
