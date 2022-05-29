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
    /// Interaction logic for EditPage.xaml
    /// </summary>
    public partial class EditPage : Window
    {
        private readonly Person _person;
        public EditPage(Person person)
        {
            InitializeComponent();

         

            if (person != null)
            {
                _person = person;

                FirstNameTextBoxEDIT.Text = _person.FirstName;
                LastNameTextBoxEDIT.Text = _person.LastName;
                DateOfBirthDatePickerEDIT.SelectedDate = _person.DateOfBirth;
                CityTextBoxEDIT.Text = _person.City;
                StreetHouseTextBoxEDIT.Text = _person.StreetHouse;
                CardNumTextBoxEDIT.Text = _person.Cardnum;
                ProblemTextBoxEDIT.Text = _person.Problem;
                DiagnoseTextBoxEDIT.Text = _person.Diagnose;
  

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
                _person.FirstName = FirstNameTextBoxEDIT.Text;
                _person.LastName = LastNameTextBoxEDIT.Text;
                _person.DateOfBirth = DateOfBirthDatePickerEDIT.SelectedDate.Value;
                _person.City= CityTextBoxEDIT.Text;
                _person.StreetHouse = StreetHouseTextBoxEDIT.Text;
                _person.Cardnum = CardNumTextBoxEDIT.Text;
                _person.Problem = ProblemTextBoxEDIT.Text;
                _person.Diagnose = DiagnoseTextBoxEDIT.Text;

                PersonDataProvider.CreatePerson(_person);

                DialogResult = true;
                Close();
            }
        }



        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (ValidatePerson())
            {
                _person.FirstName = FirstNameTextBoxEDIT.Text;
                _person.LastName = LastNameTextBoxEDIT.Text;
                _person.DateOfBirth = DateOfBirthDatePickerEDIT.SelectedDate.Value;
                _person.City = CityTextBoxEDIT.Text;
                _person.StreetHouse = StreetHouseTextBoxEDIT.Text;
                _person.Cardnum = CardNumTextBoxEDIT.Text;
                _person.Problem = ProblemTextBoxEDIT.Text;
                _person.Diagnose = DiagnoseTextBoxEDIT.Text;

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
            if (string.IsNullOrEmpty(FirstNameTextBoxEDIT.Text))
            {
                MessageBox.Show("Vezetéknév nem lehet üres!");
                return false;
            }

            if (string.IsNullOrEmpty(LastNameTextBoxEDIT.Text))
            {
                MessageBox.Show("Keresztnév nem lehet üres!");
                return false;
            }

            if (!DateOfBirthDatePickerEDIT.SelectedDate.HasValue)
            {
                MessageBox.Show("Válassza ki a születés dátumát!");
                return false;
            }

            if (string.IsNullOrEmpty(CityTextBoxEDIT.Text))
            {
                MessageBox.Show("Város mező nem lehet üres!");
                return false;
            }

            if (string.IsNullOrEmpty(StreetHouseTextBoxEDIT.Text))
            {
                MessageBox.Show("Utca-házszám nem lehet üres!");
                return false;
            }

            if (string.IsNullOrEmpty(CardNumTextBoxEDIT.Text))
            {
                MessageBox.Show("TAJ szám nem lehet üres!");
                return false;
            }
            else if (!Regex.IsMatch(CardNumTextBoxEDIT.Text, @"[0-9]{3}[ ][0-9]{3}[ ][0-9]{3}"))
            {
                MessageBox.Show("Nem megfelelő formátum!\nJavasolt: 000 000 000");
                return false;
            }

            if (string.IsNullOrEmpty(ProblemTextBoxEDIT.Text))
            {
                MessageBox.Show("Probléma nem lehet üres!");
                return false;
            }

            if (string.IsNullOrEmpty(DiagnoseTextBoxEDIT.Text))
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
