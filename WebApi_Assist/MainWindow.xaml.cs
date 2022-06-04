using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using WebApi_Client;
using WebApi_Client.DataProviders;
using WebApi_Common.Models;

namespace WebApi_Assist
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> PERSON { get; set; } = (List<Person>)PersonDataProvider.GetPeople();

        public MainWindow()
        {
            InitializeComponent();
            SetTimer();
            DataGrid.Visibility = Visibility.Collapsed;
            HideButton.Visibility = Visibility.Collapsed;
            BottomBarHided.Visibility = Visibility.Collapsed;
        }

        private void AddPerson_Click(object sender, RoutedEventArgs args)
        {
            //Nullal hívjuk így csak a create button fog látszani
            var window = new PersonWindow(null);
            //Megnyit egy ablakot és akkor tér vissza, ha a megnyitott ablak bezárul
            if (window.ShowDialog() ?? false)
            {
                UpdatePeopleListBox();
            }
        }

        //Frissíti az adatokat
        private void UpdatePeopleListBox()
        {
            //A PDP osztályon keresztül meghívja a szervert, elkéri az összes person objektumot
            var people = PersonDataProvider.GetPeople().ToList();
            DataGrid.ItemsSource = people;
        }


        //Manuális frissítés
        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            UpdatePeopleListBox();
        }

        //Időzítő, 60 másodpercenként frissít
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

        //Kijelentkezés
        private void Button_Click_Logout(object sender, RoutedEventArgs e)
        {
            LoginAssistant win2 = new LoginAssistant();
            win2.Show();
            this.Close();
        }

        //Eltűnteni az adatokat, gombokat
        private void Hide_Click(object sender, RoutedEventArgs e)
        {
            DataGrid.Visibility = Visibility.Collapsed;
            HideButton.Visibility = Visibility.Collapsed;
            ShowButton.Visibility = Visibility.Visible;
            BottomBarHided.Visibility = Visibility.Collapsed;
        }

        //Megjeleníti az adatokat, gombokat
        private void Show_Click(object sender, RoutedEventArgs e)
        {
            DataGrid.Visibility = Visibility.Visible;
            HideButton.Visibility = Visibility.Visible;
            ShowButton.Visibility = Visibility.Collapsed;
            BottomBarHided.Visibility = Visibility.Visible;
        }
        
        //Ablak mozgatás
        private void MovePanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        //Program bezárás
        private void Button_Click_Close(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        //Program letálcázás
        private void Button_Click_Talca(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
