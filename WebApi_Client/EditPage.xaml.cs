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
            MessageBoxResult msgBoxResult = MessageBox.Show("Biztosan törlöd?",
                "Igen",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning,
                MessageBoxResult.No
                );
            if (msgBoxResult == MessageBoxResult.Yes)
            {
                PersonDataProvider.DeletePerson(_person.Id);

                DialogResult = true;
                Close();
            }
        }

        private bool ValidatePerson()
        {
            Alert win2 = new Alert();
            win2.AlertTEXT.Text = "Sikeres módosítás!";
            win2.Show();
            if (string.IsNullOrEmpty(FirstNameTextBoxEDIT.Text))
            {
                win2.AlertTEXT.Text = "Vezetéknév nem lehet üres!";

                //MessageBox.Show("Vezetéknév nem lehet üres!");
                return false;
            }
            else if (!Regex.IsMatch(FirstNameTextBoxEDIT.Text, @"^[a-zA-ZöüóőúéáűíÖÜÓŐÚÉÁŰÍ](.*[a-zA-ZöüóőúéáűíÖÜÓŐÚÉÁŰÍ])?$"))
            {
                win2.AlertTEXT.Text = "Vezetéknév nem megfelelő formátum!\nNem lehet: üres, whitespace, különleges karakter. (!?_-:;#)";
                return false;
            }

            if (string.IsNullOrEmpty(LastNameTextBoxEDIT.Text))
            {
                win2.AlertTEXT.Text = "Keresztnév nem lehet üres!";
                return false;
            }
            else if (!Regex.IsMatch(LastNameTextBoxEDIT.Text, @"^[a-zA-ZöüóőúéáűíÖÜÓŐÚÉÁŰÍ](.*[a-zA-ZöüóőúéáűíÖÜÓŐÚÉÁŰÍ])?$"))
            {
                win2.AlertTEXT.Text = "Keresztnév nem megfelelő formátum!\nNem lehet: üres, whitespace, különleges karakter. (!?_-:;#)";
                return false;
            }

            if (!DateOfBirthDatePickerEDIT.SelectedDate.HasValue)
            {
                win2.AlertTEXT.Text = "Válassza ki a születés dátumát!";
                return false;
            }

            if (string.IsNullOrEmpty(CityTextBoxEDIT.Text))
            {
                win2.AlertTEXT.Text = "Város mező nem lehet üres!";
                return false;
            }

            if (string.IsNullOrEmpty(StreetHouseTextBoxEDIT.Text))
            {
                win2.AlertTEXT.Text = "Utca-házszám nem lehet üres!";
                return false;
            }
            else if (!Regex.IsMatch(StreetHouseTextBoxEDIT.Text, @"^([^\d]*[^\d\s]) *(\d.*)$"))
            {
                win2.AlertTEXT.Text = "Nem megfelelő utca-házszám formátum\n(utcanév szám)!";
                return false;
            }

            if (string.IsNullOrEmpty(CardNumTextBoxEDIT.Text))
            {
                win2.AlertTEXT.Text = "TAJ szám nem lehet üres!";
                return false;
            }
            else if (!Regex.IsMatch(CardNumTextBoxEDIT.Text, @"^[0-9]{3}[ ][0-9]{3}[ ][0-9]{3}$"))
            {
                win2.AlertTEXT.Text = "Nem megfelelő TAJ formátum!\nJavasolt: 000 000 000";
                return false;
            }

            if (string.IsNullOrEmpty(ProblemTextBoxEDIT.Text))
            {
                win2.AlertTEXT.Text = "Probléma nem lehet üres!";
                return false;
            }

            if (string.IsNullOrEmpty(DiagnoseTextBoxEDIT.Text))
            {
                win2.AlertTEXT.Text = "Diagnózis nem lehet üres!";
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
