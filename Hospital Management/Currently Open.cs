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
using System.Data;
using System.Data.SqlClient;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_Management
{
    public partial class Currently_Open : Form
    {
        SqlConnection con = new SqlConnection("server=IT-PC3\\SQLEXPRESS;DataBase=testDB;Integrated Security=true");

        public Currently_Open()
        {
            InitializeComponent();
            SqlDataAdapter ad = new SqlDataAdapter("select * from tblPatient", con);
            DataTable d = new DataTable();
            ad.Fill(d);
            dataGridView1.DataSource = d;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                StreamReader sr = new StreamReader(txtSearch.Text);
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                string line;
                bool fund = false;
                do
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] linedata = line.Split(';');
                        if (linedata.Contains(txtSearch.Text))
                        {
                            dataGridView1.Rows.Add(linedata);
                            fund = true;
                        }
                    }
                }

                while (line != null);
                sr.Close();

                if (fund == false)
                {
                    MessageBox.Show("Not Fund!");
                }
                else
                {
                    int i = dataGridView1.Rows.Count;
                    MessageBox.Show(i + "Result!");
                }
            }
            else
            {

            }
        }
    }
}
