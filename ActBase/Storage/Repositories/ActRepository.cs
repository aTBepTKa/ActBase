using ActBase.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ActBase.Storage.Repositories
{
    public class ActRepository : RepositoryBase<Act>, IActRepository
    {
        public ActRepository(ActBaseContext actBaseContext) : base(actBaseContext)
        {            
        }

        public override async Task<IEnumerable<Act>> GetAllAsync() =>
            await dbSet.Include(x => x.Materials).AsNoTracking().ToArrayAsync();
    }
}
