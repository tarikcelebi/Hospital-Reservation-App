using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace TakeReservationApp
{
    public partial class Form3 : Form
    {
        public List<Patient> Patients;

        public Form3()
        {
            InitializeComponent();
            Patients = new List<Patient>();
        }

        public Form3(List<Patient> patients)
        {
            InitializeComponent();

            Patients = patients;

            lstPatients.Items.Clear();

            foreach (Patient pat in Patients)
            {
                lstPatients.Items.Add($"{pat.NameSurname} {pat.Date} {pat.Time} ");
            }
        }

        private void lstPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPatients.SelectedIndex != -1 && lstPatients.SelectedIndex < lstPatients.Items.Count)
            {

                Patient selectedPatient = Patients[lstPatients.SelectedIndex];


                MessageBox.Show($"İsim Soyisim: {selectedPatient.NameSurname}\nTarih: {selectedPatient.Date}\nSaat: {selectedPatient.Time}\nNumara : {selectedPatient.Phone}\n TC : {selectedPatient.TC}\n Cinsiyet : {selectedPatient.Gender} ");
            }
        }


    }
}
