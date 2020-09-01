using ActBase.Storage.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ActBase.Storage
{
    public class UnitOfWork : IDisposable
    {
        private readonly ActBaseContext actBaseContext = new ActBaseContext();
        private ActRepository actRepository;

        public ActRepository ActRepository
        {
            get => actRepository ??= new ActRepository(actBaseContext);
        }

        public UnitOfWork()
        {
            actBaseContext.Database.EnsureCreated();
        }

        public void Dispose()
        {
            actBaseContext.Dispose();
        }

        public async Task SaveChangesAsync()
        {
            await actBaseContext.SaveChangesAsync();
        }
    }
}
