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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("server=IT-PC3\\SQLEXPRESS;DataBase=testDB;Integrated Security=true");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlDataAdapter ad = new SqlDataAdapter("select * from tblUsers where username='"+textName.Text+"' and password='"+textPassword.Text+"' ", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if (dt.Rows.Count>0)
            {
                // MessageBox.Show("welcome to hospital management");
                main f = new main();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("username or password is wrong..!");

            }
        }
    }
}
