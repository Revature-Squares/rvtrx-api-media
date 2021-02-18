using System.Collections.Generic;
using System.Threading.Tasks;

namespace RVTR.Media.Domain.Interfaces
{
  public interface IRepository<TEntity> where TEntity : class
  {
    Task DeleteAsync(string groupIdentifier);
    Task InsertAsync(TEntity entry);
    Task<IEnumerable<TEntity>> SelectAsync();
    Task<TEntity> SelectAsync(string groupIdentifier);
    void Update(TEntity entry);
  }
}
