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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_Management
{
    public partial class patient : Form
    {
        SqlConnection con = new SqlConnection("server=IT-PC3\\SQLEXPRESS;DataBase=testDB;Integrated Security=true");

        public patient()
        {
            InitializeComponent();
            button2.Enabled = false;

            SqlDataAdapter ad = new SqlDataAdapter("select * from tblPatient", con);
            DataTable d = new DataTable();
            ad.Fill(d);
            dataGridView1.DataSource = d;
        }

        private void patient_Load(object sender, EventArgs e)
        {

        }

        private void btnSavePatient_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into tblPatient values('" + textName.Text + "', '" + textPhone.Text + "', '" + textAddress.Text + "', '" + Convert.ToInt32(textAge.Text) + "', '" + textState.Text + "', '" + comboSection.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("add successfully..!");


            textName.Text = "";
            textPhone.Text = "";
            textAddress.Text = "";
            textAge.Text = "";
            textState.Text = "";
            comboSection.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you want to delete the selected row??") == DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand("delete from tblPatient where id = '" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value) + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("delete successfully..!");
                SqlDataAdapter ad = new SqlDataAdapter("select * from tblPatient", con);
                DataTable d = new DataTable();
                ad.Fill(d);
                dataGridView1.DataSource = d;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Visible = true;
            label8.Visible = true;
            btnSavePatient.Enabled = false;
            button2.Enabled = true;

            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textPhone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textAddress.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textAge.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textState.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboSection.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update tblPatient set Name='" + textName.Text + "', Phone='" + textPhone.Text + "',Address='" + textAddress.Text + "',Age='" + Convert.ToInt32(textAge.Text) + "', State='" + textState.Text + "',Section='" + comboSection.Text + "' where ID= '" + Convert.ToInt32(textBox1.Text) + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("edit info successfully", "update data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            SqlDataAdapter ad = new SqlDataAdapter("select * from tblPatient", con);
            DataTable d = new DataTable();
            ad.Fill(d);
            dataGridView1.DataSource = d;


            label8.Visible = false;


            textName.Text = "";
            textPhone.Text = "";
            textAddress.Text = "";
            textAge.Text = "";
            textState.Text = "";
            comboSection.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
