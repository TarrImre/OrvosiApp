using System;
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

        //Person objektummal példányosítom
        public PersonWindow(Person person)
        {
            InitializeComponent();

            if (person != null)
            {
                _person = person;

                //Hivatkozok a boxokra.
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

            }
            //Ha nem adunk át Person objektumot, ekkor hozunk létre
            else
            {
                _person = new Person();

                CreateButton.Visibility = Visibility.Visible;
            }
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            //Ha kivan töltve a UI...
            if (ValidatePerson())
            {
                //Kitöltjük a _person objektumot azzal az adatokkal amiket megadunk
                _person.FirstName = FirstNameTextBox.Text;
                _person.LastName = LastNameTextBox.Text;
                _person.DateOfBirth = DateOfBirthDatePicker.SelectedDate.Value;
                _person.City= CityTextBox.Text;
                _person.StreetHouse = StreetHouseTextBox.Text;
                _person.Cardnum = CardNumTextBox.Text;
                _person.Problem = ProblemTextBox.Text;
                _person.Diagnose = DiagnoseTextBox.Text;
                _person.AddedTime = DateTime.Now;

                //A PersonDataProvider osztállyal hívjuk meg a szerver oldalt, hogy tárolja el a persont
                PersonDataProvider.CreatePerson(_person);

                //Azt jelzi, hogy adunk át valamilyen eredményt az ablakkal, ha X-el zárjuk be False marad.
                DialogResult = true;
                Close();
            }
        }

        //Adatok ellenőrzése
        private bool ValidatePerson()
        {
            Alert win2 = new Alert();
            win2.AlertTEXT.Text = "Sikeres felvétel!";
            win2.Show();  
            
            if (string.IsNullOrEmpty(FirstNameTextBox.Text))
            {
                win2.AlertTEXT.Text = "Vezetéknév nem lehet üres!";
                return false;
            }
            else if (!Regex.IsMatch(FirstNameTextBox.Text, @"^[a-zA-ZöüóőúéáűíÖÜÓŐÚÉÁŰÍ](.*[a-zA-ZöüóőúéáűíÖÜÓŐÚÉÁŰÍ])?$"))
            {
                win2.AlertTEXT.Text = "Vezetéknév nem megfelelő formátum!\nNem lehet: üres, whitespace, különleges karakter. (!?_-:;#)";
                return false;
            }

            if (string.IsNullOrEmpty(LastNameTextBox.Text))
            {
                win2.AlertTEXT.Text = "Keresztnév nem lehet üres!";
                return false;
            }
            else if (!Regex.IsMatch(LastNameTextBox.Text, @"^[a-zA-ZöüóőúéáűíÖÜÓŐÚÉÁŰÍ](.*[a-zA-ZöüóőúéáűíÖÜÓŐÚÉÁŰÍ])?$"))
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
            else if (!Regex.IsMatch(StreetHouseTextBox.Text, @"^([^\d]*[^\d\s]) *(\d.*)$"))
            {
                win2.AlertTEXT.Text = "Nem megfelelő utca-házszám formátum\n(utcanév szám)!";
                return false;
            }

            if (string.IsNullOrEmpty(CardNumTextBox.Text))
            {
                win2.AlertTEXT.Text = "TAJ szám nem lehet üres!";
                return false;
            }
            else if(!Regex.IsMatch(CardNumTextBox.Text, @"^[0-9]{3}[ ][0-9]{3}[ ][0-9]{3}$"))
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
                win2.AlertTEXT.Text = "Diagnózis nem lehet üres!";
                return false;
            }

            return true;
        }

        //Ablak mozgatás
        private void MovePanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        //Ablak bezárás
        private void Button_Click_Close(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
