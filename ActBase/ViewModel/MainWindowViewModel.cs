using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using ActBase.DbContext;
using ActBase.Model;
using ActBase.Services;
using Microsoft.EntityFrameworkCore;

namespace ActBase.ViewModel
{
    /// <summary>
    /// Модель данных для главного окна.
    /// </summary>
    public class MainWindowViewModel
    {
        private readonly ActService actService = new ActService();

        public ObservableCollection<Act> Acts { get; set; }
        public IEnumerable<Material> Materials { get; set; }

        /// <summary>
        /// Назначить контекст данных.
        /// </summary>
        /// <returns></returns>
        public async Task SetContextAsync()
        {
            Acts = await actService.GetActsAsync();
            Materials = await actService.GetMaterialsAsync();
        }

        /// <summary>
        /// Сохранить изменения.
        /// </summary>
        public async Task SaveChanges()
        {
            await actService.SaveChangesAsync();
        }

        public async Task Dispose()
        {
            await actService.Dispose();
        }

        #region Commands
        private RelayCommand saveChangesCommand;

        public RelayCommand SaveChangesCommand
        {
            get => saveChangesCommand ??= new RelayCommand(async x =>
            {
                await actService.SaveChangesAsync();
            });
        }
        #endregion
    }
}
