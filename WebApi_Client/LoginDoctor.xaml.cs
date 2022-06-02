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
using System.Windows.Shapes;
using WebApi_Client;

namespace WebApi_Client
{
    /// <summary>
    /// Interaction logic for LoginDoctor.xaml
    /// </summary>
    public partial class LoginDoctor : Window
    {
        public LoginDoctor()
        {
            InitializeComponent();
            LoginPanelLoading.Visibility = Visibility.Collapsed;
            textBlock.Visibility = Visibility.Collapsed;
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

        private void Button_Click_Login(object sender, RoutedEventArgs e)
        {
            LoginPanel.Visibility = Visibility.Collapsed;
            LoginPanelLoading.Visibility = Visibility.Visible;
            textBlock.Visibility = Visibility.Visible;
            MainWindow win2 = new MainWindow();
                win2.Show();
                this.Close();
        }

        private void Button_Click_Talca(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
