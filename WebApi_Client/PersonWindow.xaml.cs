using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
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
                DiagnoseTextBox.Text = _person.Diagnose;
                AddedTimeText.Text = DateTime.Now.ToString();

                AddedTimeText.Visibility = Visibility.Collapsed;
                CreateButton.Visibility = Visibility.Collapsed;
                UpdateButton.Visibility = Visibility.Visible;
                DeleteButton.Visibility = Visibility.Visible;
            }
            else
            {
                _person = new Person();

                CreateButton.Visibility = Visibility.Visible;
                UpdateButton.Visibility = Visibility.Collapsed;
                DeleteButton.Visibility = Visibility.Collapsed;
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
                _person.Diagnose = DiagnoseTextBox.Text;
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

        private bool ValidatePerson()
        {
            if (string.IsNullOrEmpty(FirstNameTextBox.Text))
            {
                MessageBox.Show("Vezetéknév nem lehet üres!");
                return false;
            }
            else if (!Regex.IsMatch(FirstNameTextBox.Text, @"^[a-zA-ZöüóőúéáűíÖÜÓŐÚÉÁŰÍ](.*[a-zA-ZöüóőúéáűíÖÜÓŐÚÉÁŰÍ])?$"))
            {
                MessageBox.Show("Vezetéknév nem megfelelő formátum!\nNem lehet: üres, whitespace, különleges karakter. (!?_-:;#)");
                return false;
            }

            if (string.IsNullOrEmpty(LastNameTextBox.Text))
            {
                MessageBox.Show("Keresztnév nem lehet üres!");
                return false;
            }
            else if (!Regex.IsMatch(LastNameTextBox.Text, @"^[a-zA-ZöüóőúéáűíÖÜÓŐÚÉÁŰÍ](.*[a-zA-ZöüóőúéáűíÖÜÓŐÚÉÁŰÍ])?$"))
            {
                MessageBox.Show("Keresztnév nem megfelelő formátum!\nNem lehet: üres, whitespace, különleges karakter. (!?_-:;#)");
                return false;
            }

            if (!DateOfBirthDatePicker.SelectedDate.HasValue)
            {
                MessageBox.Show("Válassza ki a születés dátumát!");
                return false;
            }

            if (string.IsNullOrEmpty(CityTextBox.Text))
            {
                MessageBox.Show("Város mező nem lehet üres!");
                return false;
            }

            if (string.IsNullOrEmpty(StreetHouseTextBox.Text))
            {
                MessageBox.Show("Utca-házszám nem lehet üres!");
                return false;
            }

            if (string.IsNullOrEmpty(CardNumTextBox.Text))
            {
                MessageBox.Show("TAJ szám nem lehet üres!");
                return false;
            }
            else if(!Regex.IsMatch(CardNumTextBox.Text, @"^[0-9]{3}[ ][0-9]{3}[ ][0-9]{3}$"))
            {
                MessageBox.Show("Nem megfelelő TAJ formátum!\nJavasolt: 000 000 000");
                return false;
            }

            if (string.IsNullOrEmpty(ProblemTextBox.Text))
            {
                MessageBox.Show("Probléma nem lehet üres!");
                return false;
            }

            if (string.IsNullOrEmpty(DiagnoseTextBox.Text))
            {
                MessageBox.Show("Diagnózis nem lehet üres!");
                return false;
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
