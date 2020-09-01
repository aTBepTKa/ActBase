using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActBase.Storage.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly ActBaseContext actBaseContext;
        protected readonly DbSet<T> dbSet;
        public RepositoryBase(ActBaseContext actBaseContext)
        {
            this.actBaseContext = actBaseContext;
            dbSet = actBaseContext.Set<T>();
        }
        public virtual async Task<IEnumerable<T>> GetAllAsync() =>
            await dbSet.ToArrayAsync();

        public virtual void Update(T entity) =>
            dbSet.Update(entity);

        public virtual void Update(IEnumerable<T> entities)
        {
            actBaseContext.UpdateRange(entities);
        }

        public virtual void SetStateModifed(IEnumerable<T> entities)
        {
            actBaseContext.Attach(entities).State = EntityState.Modified;
        }

        public virtual async Task SaveChangesAsync() =>
            await actBaseContext.SaveChangesAsync();

    }
}
