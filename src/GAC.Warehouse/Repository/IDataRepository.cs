using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GAC.Warehouse.Repository
{
  public interface IDataRepository<TEntity>
  {
    IEnumerable<TEntity> GetAll();
    TEntity Get(long id);
    int? Add(TEntity entity);
    void Update(TEntity dbEntity, TEntity entity);
    void Delete(TEntity entity);
  }
}
