using ActBase.Model;
using ActBase.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private readonly IActService actService;
        public ObservableCollection<ActModel> Acts { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            actService = new ActService();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Acts = await actService.GetAllAsync();
            DataContext = this;
        }

        private async void SaveChangesButton_Click(object sender, RoutedEventArgs e)
        {
            await actService.UpdateAsync((ActModel)actDataGrid.CurrentItem);
            Acts = await actService.GetAllAsync();
            actDataGrid.Items.Refresh();
            materialsDataGrid.Items.Refresh();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            actService.Dispose();
        }
    }
}
