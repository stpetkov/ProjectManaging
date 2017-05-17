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


namespace projects
{
    public partial class SearchExpert : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-97V1D5E\SQLEXPRESS;Initial Catalog=ProjectManagement;Integrated Security=True");
        public SearchExpert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 srch = new Form1();
            srch.Show();
            this.Hide();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand search = con.CreateCommand();
            // new code from here
            string IorE = "I";
            if (radioButton2.Checked)
            {
                IorE = "E";
            }
            search.CommandType = CommandType.Text;
            search.CommandText = @"SELECT EXPRET_ID, EXPERT_TYPE, EXPERT_NAME, EXPERT_SURNAME, EXPERT_LASTNAME 
                                   FROM EXPERTS 
                                   WHERE EXPERT_TYPE like '%" + IorE + "%' AND EXPERT_NAME like '%" + nameTxt.Text + "%' AND EXPERT_SURNAME like '%" + snameTxt.Text + "%' AND EXPERT_LASTNAME like '%" + lnameTxt.Text + "%'";
            
            search.ExecuteNonQuery();
            // till here
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(search);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {

        }
    }
    }

