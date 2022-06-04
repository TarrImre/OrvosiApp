using System.Windows;
using System.Windows.Input;

namespace WebApi_Assist
{
    /// <summary>
    /// Interaction logic for LoginAssistant.xaml
    /// </summary>
    public partial class LoginAssistant : Window
    {
        public LoginAssistant()
        {
            InitializeComponent();
            LoginPanelLoading.Visibility = Visibility.Collapsed;
        }

        //Bejelentkezés gomb lenyomása után megjelenik a MainWindow
        private void Button_Click_Login(object sender, RoutedEventArgs e)
        {
            LoginPanel.Visibility = Visibility.Collapsed;
            LoginPanelLoading.Visibility = Visibility.Visible;
            MainWindow win2 = new MainWindow();
            win2.Show();
            this.Close();
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
