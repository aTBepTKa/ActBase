using ActBase.DbContext;
using ActBase.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ActBase
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ActContext Context;
        public MainWindow()
        {
            InitializeComponent();            
        }

        private void SaveChangesButton_Click(object sender, RoutedEventArgs e)
        {
            Context.SaveChangesAsync();
            actDataGrid.Items.Refresh();
            materialsDataGrid.Items.Refresh();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Context.Dispose();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Context = new ActContext();
            Context.Database.EnsureCreated();
            DataContext = new MainWindowViewModel(Context);
        }
    }
}
