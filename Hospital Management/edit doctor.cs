using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class edit_doctor : Form
    {
        SqlConnection con = new SqlConnection("server=IT-PC3\\SQLEXPRESS;DataBase=testDB;Integrated Security=true");

        public edit_doctor()
        {
            InitializeComponent();
        }

        private void edit_doctor_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveDoctor_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update doctors set Name = '" + textName.Text + "', Phone = '" + textPhone.Text + "', Section = '" + comboSection.Text + "', Address = '" + textAddress.Text + "' where ID= '" + Convert.ToInt32(textID.Text) + "' ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("edit info successfully..!!");

            textName.Text = "";
            textPhone.Text = "";
            textAddress.Text = "";
            comboSection.Text = "";

            SqlDataAdapter ad = new SqlDataAdapter("select * from doctors", con);
            DataTable d = new DataTable();
            ad.Fill(d);

        }
    }
}
