using System.Windows;
using System.Windows.Input;

namespace WebApi_Assist
{
    /// <summary>
    /// Interaction logic for Alert.xaml
    /// </summary>
    public partial class Alert : Window
    {
        public Alert()
        {
            InitializeComponent();
        }

        //Ablak mozgatás
        private void MovePanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        //Ablak bezárás (X)
        private void Button_Click_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //Ablak bezárás (Rendben)
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
