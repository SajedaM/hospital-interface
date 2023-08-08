using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelProgrammer.Left += 8;
            if (labelProgrammer.Left > this.Width)
                labelProgrammer.Left -= this.Width;
        }

        private void addDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_doctor f = new add_doctor();
            f.Show();
        }

        private void manageDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manage_doctor f = new manage_doctor();
            f.Show();
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void addProccessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_Proccess f = new add_Proccess();
            f.Show();
        }

        private void manageProccessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewproccess f = new viewproccess();
            f.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sitPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patient frm = new patient();
            frm.Show();
        }

        private void searchPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Currently_Open frm = new Currently_Open();
            frm.Show();
        }
    }
}
