using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using WebApi_Assist;
using WebApi_Client.DataProviders;
using WebApi_Common.Models;

namespace WebApi_Client
{
    /// <summary>
    /// Interaction logic for PersonWindow.xaml
    /// </summary>
    public partial class PersonWindow : Window
    {
        private readonly Person _person;
        public static Regex regexName = new Regex(@"^[a-zA-ZöüóőúéáűíÖÜÓŐÚÉÁŰÍ](.*[a-zA-ZöüóőúéáűíÖÜÓŐÚÉÁŰÍ])?$");
        public static Regex regexCardNum = new Regex(@"^[0-9]{3}[ ][0-9]{3}[ ][0-9]{3}$");
        public static Regex regexStreetHouse = new Regex(@"^([^\d]*[^\d\s]) *(\d.*)$");
        public PersonWindow(Person person)
        {
            InitializeComponent();

         

            if (person != null)
            {
                _person = person;

                FirstNameTextBox.Text = _person.FirstName;
                LastNameTextBox.Text = _person.LastName;
                DateOfBirthDatePicker.SelectedDate = _person.DateOfBirth;
                CityTextBox.Text = _person.City;
                StreetHouseTextBox.Text = _person.StreetHouse;
                CardNumTextBox.Text = _person.Cardnum;
                ProblemTextBox.Text = _person.Problem;
                //DiagnoseTextBox.Text = _person.Diagnose;
                AddedTimeText.Text = DateTime.Now.ToString();

                AddedTimeText.Visibility = Visibility.Collapsed;
                CreateButton.Visibility = Visibility.Collapsed;
            }
            else
            {
                _person = new Person();
                CreateButton.Visibility = Visibility.Visible;
            }
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            if (ValidatePerson())
            {
                _person.FirstName = FirstNameTextBox.Text;
                _person.LastName = LastNameTextBox.Text;
                _person.DateOfBirth = DateOfBirthDatePicker.SelectedDate.Value;
                _person.City= CityTextBox.Text;
                _person.StreetHouse = StreetHouseTextBox.Text;
                _person.Cardnum = CardNumTextBox.Text;
                _person.Problem = ProblemTextBox.Text;
                _person.Diagnose = "!Megadásra vár...";
                _person.AddedTime = DateTime.Now;

                PersonDataProvider.CreatePerson(_person);

                DialogResult = true;
                Close();
            }
        }



        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (ValidatePerson())
            {
                _person.FirstName = FirstNameTextBox.Text;
                _person.LastName = LastNameTextBox.Text;
                _person.DateOfBirth = DateOfBirthDatePicker.SelectedDate.Value;
                _person.City = CityTextBox.Text;
                _person.StreetHouse = StreetHouseTextBox.Text;
                _person.Cardnum = CardNumTextBox.Text;
                _person.Problem = ProblemTextBox.Text;
                _person.Diagnose = DiagnoseTextBox.Text;

                PersonDataProvider.UpdatePerson(_person);

                DialogResult = true;
                Close();
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Biztosan akarod törölni?", "Question", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                PersonDataProvider.DeletePerson(_person.Id);

                DialogResult = true;
                Close();
            }
        }

        public bool ValidatePerson()
        {
            Alert win2 = new Alert();
            win2.AlertTEXT.Text = "Sikeres felvétel!";
            win2.Show();
            if (string.IsNullOrEmpty(FirstNameTextBox.Text))
            {
                win2.AlertTEXT.Text = "Vezetéknév nem lehet üres!";

                //MessageBox.Show("Vezetéknév nem lehet üres!");
                return false;
            }
            else if (!regexName.IsMatch(FirstNameTextBox.Text))
            {
                win2.AlertTEXT.Text = "Vezetéknév nem megfelelő formátum!\nNem lehet: üres, whitespace, különleges karakter. (!?_-:;#)";
                return false;
            }

            if (string.IsNullOrEmpty(LastNameTextBox.Text))
            {
                win2.AlertTEXT.Text = "Keresztnév nem lehet üres!";
                return false;
            }

            else if (!regexName.IsMatch(LastNameTextBox.Text))
            {
                win2.AlertTEXT.Text = "Keresztnév nem megfelelő formátum!\nNem lehet: üres, whitespace, különleges karakter. (!?_-:;#)";
                return false;
            }

            if (!DateOfBirthDatePicker.SelectedDate.HasValue)
            {
                win2.AlertTEXT.Text = "Válassza ki a születés dátumát!";
                return false;
            }

            if (string.IsNullOrEmpty(CityTextBox.Text))
            {
                win2.AlertTEXT.Text = "Város mező nem lehet üres!";
                return false;
            }

            if (string.IsNullOrEmpty(StreetHouseTextBox.Text))
            {
                win2.AlertTEXT.Text = "Utca-házszám nem lehet üres!";
                return false;
            }
            else if (!regexStreetHouse.IsMatch(StreetHouseTextBox.Text)) {
                win2.AlertTEXT.Text = "Nem megfelelő utca-házszám formátum\n(utcanév szám)!";
                return false;
            }

            if (string.IsNullOrEmpty(CardNumTextBox.Text))
            {
                win2.AlertTEXT.Text = "TAJ szám nem lehet üres!";
                return false;
            }
            else if (!regexCardNum.IsMatch(CardNumTextBox.Text))
            {
                win2.AlertTEXT.Text = "Nem megfelelő TAJ formátum!\nJavasolt: 000 000 000";
                return false;
            }

            if (string.IsNullOrEmpty(ProblemTextBox.Text))
            {
                win2.AlertTEXT.Text = "Probléma nem lehet üres!";
                return false;
            }

            if (string.IsNullOrEmpty(DiagnoseTextBox.Text))
            {
                //MessageBox.Show("Diagnózis nem lehet üres!");
                return true;
            }

            return true;
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
            Close();
        }
        /*private void Button_Click_Talca(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }*/
    }
}
