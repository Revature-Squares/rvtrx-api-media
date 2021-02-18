using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RVTR.Media.Domain.Interfaces;

namespace RVTR.Media.Context.Repositories
{
  /// <summary>
  /// Represents the _Repository_ generic
  /// </summary>
  /// <typeparam name="TEntity"></typeparam>
  public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
  {
    protected readonly DbSet<TEntity> Db;

    public Repository(MediaContext context)
    {
      Db = context.Set<TEntity>();
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="groupIdentifier"></param>
    /// <returns></returns>
    public virtual async Task DeleteAsync(string groupIdentifier) => Db.Remove(await SelectAsync(groupIdentifier));

    public virtual async Task InsertAsync(TEntity entry) => await Db.AddAsync(entry).ConfigureAwait(true);

    public virtual async Task<IEnumerable<TEntity>> SelectAsync() => await Db.ToListAsync();

    public virtual async Task<TEntity> SelectAsync(string groupIdentifier) => await Db.FindAsync(groupIdentifier).ConfigureAwait(true);

    public virtual void Update(TEntity entry) => Db.Update(entry);
  }
}
