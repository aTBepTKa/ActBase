using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Data;
using ActBase.DbContext;
using ActBase.Model;
using Microsoft.EntityFrameworkCore;

namespace ActBase.ViewModel
{
    public class MainWindowViewModel
    {
        ActContext Context;
        public ObservableCollection<Act> Acts { get; set; }

        public MainWindowViewModel(ActContext context)
        {
            Context = context;
            Context.Acts.LoadAsync();
            Acts = Context.Acts.Local.ToObservableCollection();
        }

        #region Commands
        private RelayCommand saveChangesCommand;

        public RelayCommand SaveChangesCommand
        {
            get => saveChangesCommand ??= new RelayCommand(x =>
            {
                Context.SaveChangesAsync();
            });
        }
        #endregion
    }
}
