using ActBase.DbContext;
using ActBase.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace ActBase.Services
{
    class ActService
    {
        /// <summary>
        /// Контекст базы данных.
        /// </summary>
        public ActBaseContext actBaseContext { get; } = new ActBaseContext();

        public ActService()
        {
            actBaseContext.Database.EnsureCreated();
        }

        /// <summary>
        /// Получить коллекцию актов для отслеживания.
        /// </summary>
        /// <returns></returns>
        public async Task<ObservableCollection<Act>> GetActsAsync()
        {
            await actBaseContext.Acts.LoadAsync();
            return actBaseContext.Acts.Local.ToObservableCollection();
        }

        public async Task<IEnumerable<Material>> GetMaterialsAsync()
        {
            return await actBaseContext.Materials.AsNoTracking().ToArrayAsync();
        }

        /// <summary>
        /// Сохранить изменения в актах.
        /// </summary>
        /// <returns></returns>
        public async Task SaveChangesAsync()
        {
            await actBaseContext.SaveChangesAsync();
        }

        /// <summary>
        /// Завершить работу с БД.
        /// </summary>
        /// <returns></returns>
        public async Task Dispose()
        {
            await actBaseContext.DisposeAsync();
        }
    }
}
