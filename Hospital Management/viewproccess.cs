using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class viewproccess : Form
    {
        SqlConnection con = new SqlConnection("server=IT-PC3\\SQLEXPRESS;DataBase=testDB;Integrated Security=true");

        public viewproccess()
        {
            InitializeComponent();
            SqlDataAdapter ad = new SqlDataAdapter("select * from proce", con);
            DataTable d = new DataTable();
            ad.Fill(d);
            dataGridView1.DataSource = d;
        }

        private void viewproccess_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter ad = new SqlDataAdapter("select * from proce where prodate like '%"+textBox1.Text +"%'", con);
            DataTable d = new DataTable();
            StreamReader sr = new StreamReader(textBox1.Text);

            ad.Fill(d);
            dataGridView1.DataSource = d;
        }
    }
}
