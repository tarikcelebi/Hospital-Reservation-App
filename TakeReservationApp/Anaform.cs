using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeReservationApp
{
    public partial class Anaform : Form
    {
        Form1 Form1;
        Form3 Form3;

        public Anaform()
        {
            InitializeComponent();

            Form1 = new Form1();
            Form3 = new Form3();

        }


        private void randevuOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormAc(Form1);
            Form1.MdiParent = this;
            Form1.Show();

        }

        private void randevularToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            FormAc(Form3);
            Form3.MdiParent = this;
            Form3.Show();

        }

        void FormAc(Form form)
        {
            Form f = form;

            foreach (Form mdiChild in MdiChildren)
            {
                if (mdiChild.Text == f.Text)
                {

                    mdiChild.BringToFront();
                    return;
                }
            }

        }

        private void Anaform_Load(object sender, EventArgs e)
        {

        }
    }
}
