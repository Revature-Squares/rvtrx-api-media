using System.Collections.Generic;
using System.Threading.Tasks;

namespace RVTR.Media.Domain.Interfaces
{
  public interface IRepository<TEntity> where TEntity : class
  {
    Task DeleteAsync(int id);
    Task InsertAsync(TEntity entry);
    Task<IEnumerable<TEntity>> SelectAsync();
    Task<IEnumerable<TEntity>> SelectAsync(string groupIdentifier);
    Task<TEntity> SelectAsync(int id);
    void Update(TEntity entry);
  }
}
