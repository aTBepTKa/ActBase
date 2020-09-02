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
        MainWindowViewModel ViewModel { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            ViewModel = new MainWindowViewModel();
        }

        private async void SaveChangesButton_Click(object sender, RoutedEventArgs e)
        {
            await ViewModel.SaveChanges();
            actDataGrid.Items.Refresh();
            materialsDataGrid.Items.Refresh();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {            
            await ViewModel.SetContextAsync();
            DataContext = ViewModel;
        }

        private async void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            await ViewModel.Dispose();
        }
    }
}
