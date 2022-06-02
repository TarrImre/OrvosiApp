using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
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
            SetTimer();
            DataGrid.Visibility = Visibility.Collapsed;
            HideButton.Visibility = Visibility.Collapsed;
        }


        private void AddPerson_Click(object sender, RoutedEventArgs args)
        {
            var window = new PersonWindow(null);
            if (window.ShowDialog() ?? false)
            {
                UpdatePeopleListBox();
            }
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            var selectedPerson = DataGrid.SelectedItem as Person;

            if (selectedPerson != null)
            {
                var window = new EditPage(selectedPerson);
                if (window.ShowDialog() ?? false)
                {
                    UpdatePeopleListBox();
                }

                DataGrid.UnselectAll();
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
        protected void Timer_Tick(object sender, EventArgs e)
        {
            UpdatePeopleListBox();
        }

        private void SetTimer()
        {
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(Timer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 60);
            dispatcherTimer.Start();
        }


        private void MovePanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void Button_Click_Close(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        private void Button_Click_Talca(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void Button_Click_Logout(object sender, RoutedEventArgs e)
        {
            LoginDoctor win2 = new LoginDoctor();
            win2.Show();
            this.Close();
        }
        
        private void CardNumSearchTXT_KeyUp(object sender, KeyEventArgs e)
        {
            var people = PersonDataProvider.GetPeople();
            var filtered = people.Where(people => people.Cardnum.StartsWith(CardNumSearchTXT.Text));
            DataGrid.ItemsSource = filtered;
        }
        private void Hide_Click(object sender, RoutedEventArgs e)
        {
            DataGrid.Visibility = Visibility.Collapsed;
            HideButton.Visibility = Visibility.Collapsed;
            ShowButton.Visibility = Visibility.Visible;

        }
        private void Show_Click(object sender, RoutedEventArgs e)
        {
            DataGrid.Visibility = Visibility.Visible;
            HideButton.Visibility = Visibility.Visible;
            ShowButton.Visibility = Visibility.Collapsed;
        }
    }
}
