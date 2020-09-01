using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ActBase.Storage.Repositories
{
    public interface IRepositoryBase<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task SaveChangesAsync();
        void SetStateModifed(IEnumerable<T> entities);
    }
}
