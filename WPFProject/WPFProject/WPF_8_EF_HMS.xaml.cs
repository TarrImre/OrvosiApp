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

namespace WPFProject
{
    /// <summary>
    /// Interaction logic for WPF_8_EF_HMS.xaml
    /// </summary>
    public partial class WPF_8_EF_HMS : Window
    {
        public WPF_8_EF_HMS()
        {
            InitializeComponent();

            HospitalManagementDBEntities db = new HospitalManagementDBEntities();
            var docs = from d in db.Doctors
                       select new {
                           PatientName = d.Name,
                           PatientBirthPlace = d.BirthPlace,
                           PatientBirthTime = d.BirthTime,
                           PatientCity = d.City,
                           PatientStreet = d.Street,
                           PatientHouseNumber=d.HouseNumber,
                           PatientZipCode=d.ZipCode,
                           PatientCardnum=d.Cardnum,
                           PatientProblem=d.Problem,
                           PatientDiagnose=d.Diagnose
                       };

            foreach (var item in docs) {
                Console.WriteLine(item.PatientName);
                Console.WriteLine(item.PatientBirthPlace);
                Console.WriteLine(item.PatientBirthTime);
                Console.WriteLine(item.PatientCity);
                Console.WriteLine(item.PatientStreet);
                Console.WriteLine(item.PatientHouseNumber);
                Console.WriteLine(item.PatientZipCode);
                Console.WriteLine(item.PatientCardnum);
                Console.WriteLine(item.PatientProblem);
                Console.WriteLine(item.PatientDiagnose);
            }

            this.gridPatients.ItemsSource = docs.ToList();

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            HospitalManagementDBEntities db = new HospitalManagementDBEntities();

            Doctor PatientObject = new Doctor()
            {
                Name = txtName.Text,
                BirthPlace=txtBirthPlace.Text,
                BirthTime=txtBirthTime.Text,
                City=txtCity.Text,
                Street=txtStreet.Text,
                HouseNumber=txtHouseNumber.Text,
                ZipCode=txtZipCode.Text,
                Cardnum=txtCardnum.Text,
                Problem=txtProblem.Text,
              //  Diagnose=txtDiagnose.Text
            };
            db.Doctors.Add(PatientObject);
            db.SaveChanges();
           // btnLoad_Click(sender,e);
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            HospitalManagementDBEntities db = new HospitalManagementDBEntities();
            this.gridPatients.ItemsSource = db.Doctors.ToList();
        }

        private int updatingPatientID = 0;
        private void gridPatients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.gridPatients.SelectedIndex >= 0)
            {
                if (this.gridPatients.SelectedItems.Count >= 0)
                {
                    if (this.gridPatients.SelectedItems[0].GetType() == typeof(Doctor))
                    {
                        Doctor d = (Doctor)this.gridPatients.SelectedItems[0];
                        this.txtName2.Text = d.Name;
                        this.txtBirthPlace2.Text = d.BirthPlace;
                        this.txtBirthTime2.Text = d.BirthTime;
                        this.txtCity2.Text = d.City;
                        this.txtStreet2.Text = d.Street;
                        this.txtHouseNumber2.Text = d.HouseNumber;
                        this.txtZipCode2.Text = d.ZipCode;
                        this.txtCardnum2.Text = d.Cardnum;
                        this.txtProblem2.Text = d.Problem;
                        this.txtDiagnose2.Text = d.Diagnose;
                        this.updatingPatientID = d.Id;

                    }
                }
            }
        }

        private void btnUpdatePatient_Click(object sender, RoutedEventArgs e)
        {
            HospitalManagementDBEntities db = new HospitalManagementDBEntities();
            var r = from d in db.Doctors
                    where d.Id == this.updatingPatientID
                    select d;
            Doctor obj = r.SingleOrDefault();
            if (obj != null) {
                
                obj.Name = this.txtName2.Text;
                obj.BirthPlace= this.txtBirthPlace2.Text;
                obj.BirthTime= this.txtBirthTime2.Text;
                obj.City= this.txtCity2.Text;
                obj.Street= this.txtStreet2.Text;
                obj.HouseNumber= this.txtHouseNumber2.Text;
                obj.ZipCode= this.txtZipCode2.Text;
                obj.Cardnum= this.txtCardnum2.Text;
                obj.Problem= this.txtProblem2.Text;
                obj.Diagnose= this.txtDiagnose2.Text;
                db.SaveChanges();
            }
      
            
        }

        private void btnDeletePatient_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult msgBoxResult = MessageBox.Show("Biztosan törlöd?",
                "Igen",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning,
                MessageBoxResult.No
                );
            if (msgBoxResult == MessageBoxResult.Yes)
            {
                HospitalManagementDBEntities db = new HospitalManagementDBEntities();
                var r = from d in db.Doctors
                        where d.Id == this.updatingPatientID
                        select d;
                Doctor obj = r.SingleOrDefault();
                if (obj != null)
                {
                    db.Doctors.Remove(obj);
                    db.SaveChanges();
                }
            }
        }
    }
}
