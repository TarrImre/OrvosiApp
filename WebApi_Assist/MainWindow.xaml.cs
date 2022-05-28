using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WebApi_Client.DataProviders;
using WebApi_Common.Models;


namespace WebApi_Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }


        private void AddPerson_Click(object sender, RoutedEventArgs args)
        {
            var window = new PersonWindow(null);
            if (window.ShowDialog() ?? false)
            {
                UpdatePeopleListBox();
            }
        }

        private void UpdatePeopleListBox()
        {
            var people = PersonDataProvider.GetPeople().ToList();
            DataGrid.ItemsSource = people;
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            UpdatePeopleListBox();
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            UpdatePeopleListBox();
        }
    }
}
