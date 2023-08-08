using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Management
{
    public partial class add_doctor : Form
    {
        SqlConnection con = new SqlConnection("server=IT-PC3\\SQLEXPRESS;DataBase=testDB;Integrated Security=true");

        public add_doctor()
        {
            InitializeComponent();
        }

        private void add_doctor_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveDoctor_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into doctors values ('" + textName.Text + "','" +textPhone.Text+"','" + comboSection.Text + "','"+ textAddress.Text+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("add doctor successfully..!");

            textName.Text = "";
            textPhone.Text = "";
            textAddress.Text = "";
            comboSection.Text = "";

        }
    }
}
