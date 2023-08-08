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
    public partial class manage_doctor : Form
    {
        SqlConnection con = new SqlConnection("server=IT-PC3\\SQLEXPRESS;DataBase=testDB;Integrated Security=true");

        public manage_doctor()
        {
            InitializeComponent();
            SqlDataAdapter ad = new SqlDataAdapter("select * from doctors", con);
            DataTable d= new DataTable();
            ad.Fill(d);
            dataGridView1.DataSource = d;
        }

        private void manage_doctor_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from doctors where id = '" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value) + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("delete successfully..!");

            SqlDataAdapter ad = new SqlDataAdapter("select * from doctors", con);
            DataTable d = new DataTable();
            ad.Fill(d);
            dataGridView1.DataSource = d;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            edit_doctor f = new edit_doctor();

            f.textID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            f.textName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f.textPhone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            f.comboSection.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            f.textAddress.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            f.Show();
        }

    }
}
