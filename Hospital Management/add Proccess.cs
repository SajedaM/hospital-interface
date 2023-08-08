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
    public partial class add_Proccess : Form
    {
        SqlConnection con = new SqlConnection("server=IT-PC3\\SQLEXPRESS;DataBase=testDB;Integrated Security=true");

        public add_Proccess()
        {
            InitializeComponent();
        }

        private void add_Proccess_Load(object sender, EventArgs e)
        {
            SqlDataAdapter d = new SqlDataAdapter("select * from doctors", con);
            DataTable t1 = new DataTable();
            d.Fill(t1);
            docBox.DataSource = t1;
            docBox.DisplayMember = "name";
            docBox.ValueMember = "id";



            SqlDataAdapter d1= new SqlDataAdapter("select * from tblPatient", con);
            DataTable t2 = new DataTable();
            d1.Fill(t2);
            patBox.DataSource = t2;
            patBox.DisplayMember = "name";
            patBox.ValueMember = "id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into proce values ('" + docBox.Text + "' , '" + Convert.ToInt32(docBox.SelectedValue) + "' , '"+ patBox.Text +"', '" + Convert.ToInt32(patBox.SelectedValue)+"', '" + dateTimePicker1.Value.ToString("yyyy-mm-dd") + "' , '" + textState.Text + "' )", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("add successfully");

        }
    }
}