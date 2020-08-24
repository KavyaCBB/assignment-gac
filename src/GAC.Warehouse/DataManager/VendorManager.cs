using GAC.Warehouse.DataBaseContext;
using GAC.Warehouse.Repository;
using IO.Swagger.Models;
using System.Collections.Generic;
using System.Linq;

namespace GAC.Warehouse.DataManager
{
  public class VendorManager : IDataRepository<Vendor>
  {
    readonly VendorContext _vendorContext;

    public VendorManager(VendorContext context)
    {
      _vendorContext = context;
    }

    public IEnumerable<Vendor> GetAll()
    {
      return _vendorContext.Vendors.ToList();
    }

    public Vendor Get(long id)
    {
      return _vendorContext.Vendors.FirstOrDefault(e => e.ID == id);
    }

    public int? Add(Vendor entity)
    {
      _vendorContext.Vendors.Add(entity);
      _vendorContext.SaveChanges();
      return entity.ID;
    }

    public void Update(Vendor vendor, Vendor entity)
    {
      vendor.ID = entity.ID;
      vendor.Name = entity.Name;
      vendor.PhoneNumber = entity.PhoneNumber;
      vendor.EmailID = entity.EmailID;
      vendor.Rating = entity.Rating;
      _vendorContext.SaveChanges();
    }

    public void Delete(Vendor vendor)
    {
      _vendorContext.Vendors.Remove(vendor);
      _vendorContext.SaveChanges();
    }
  }
}
