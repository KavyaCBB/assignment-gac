using GAC.Warehouse.DataBaseContext;
using GAC.Warehouse.Repository;
using IO.Swagger.Models;
using System.Collections.Generic;
using System.Linq;

namespace GAC.Warehouse.DataManager
{
  public class ProductManager : IDataRepository<Product>
  {
    readonly ProductContext _productContext;

    public ProductManager(ProductContext context)
    {
      _productContext = context;
    }

    public IEnumerable<Product> GetAll()
    {
      return _productContext.Products.ToList();
    }

    public Product Get(long id)
    {
      return _productContext.Products.FirstOrDefault(e => e.ID == id);
    }

    public int? Add(Product entity)
    {
      _productContext.Products.Add(entity);
      _productContext.SaveChanges();
      return entity.ID;
    }

    public void Update(Product product, Product entity)
    {
      product.ID = entity.ID;
      product.Name = entity.Name;
      //product.VendorProdRefId=entity.VendorProdRefId;
      _productContext.SaveChanges();
    }

    public void Delete(Product product)
    {
      _productContext.Products.Remove(product);
      _productContext.SaveChanges();
    }
  }
}
