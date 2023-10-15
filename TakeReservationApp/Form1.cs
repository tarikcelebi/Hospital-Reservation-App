using System.Diagnostics;
using System.Drawing.Design;

namespace TakeReservationApp
{
    public partial class Form1 : Form
    {
        public List<Patient> Patients = new List<Patient>();
        string radiobutton = string.Empty;
        string Gender = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateReservation_Click(object sender, EventArgs e)
        {
            if (rbtnTwelve.Checked)
            {
                radiobutton = rbtnTwelve.Text;
            }
            else if (rbtnOne.Checked)
            {
                radiobutton = rbtnOne.Text;
            }
            else if (rbtnThree.Checked)
            {
                radiobutton = rbtnThree.Text;
            }
            else
            {
                radiobutton = rbtnTwo.Text;
            }

            foreach (Control control in groupBox1.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton rb = (RadioButton)control;
                    if (rb.Checked)
                    {
                        Gender = rb.Text;
                        break;
                    }
                }

            }

            Patient patient = new Patient(txtNameSurname.Text, dtp1.Value, radiobutton, txtTC.Text, txtPhone.Text, Gender,cboPoliclinic.Text);


            Patients.Add(patient);


            Form3 frm3 = new Form3(Patients);
                   

            txtBoxTemizle();
        }

        private void txtBoxTemizle()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Text = string.Empty;
                }
                if (item is RadioButton)
                {
                    RadioButton rb = (RadioButton)item;
                    rb.Checked = false;
                }
                if (item is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)item;
                    dtp.Value = DateTime.Today;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}