using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projects
{
    public partial class NewProject : Form
    {
        // new code here
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-97V1D5E\SQLEXPRESS;Initial Catalog=ProjectManagement;Integrated Security=True");
        // here
        public NewProject()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Taskss srch = new Taskss(nameTxt.Text);
            srch.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 srch = new Form1();
            srch.Show();
            this.Hide();
        }

        private void NewProject_Load(object sender, EventArgs e)
        {

        }
        // new code from here and  if there is time TODO to put dateBegin and end also 
        private void saveBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand search = con.CreateCommand();
            search.CommandType = CommandType.Text;
            
            search.CommandText = "insert into PROJECTS(PROJECT_ID, PROJECT_NAME, PROJECT_DESCRIPTION," +
                " PROJECT_CLIENT, PROJECT_STATUS, PROJECT_PAY_PER_HOUR ) values ('" + noTxt.Text + "','" + nameTxt.Text + "','" + descriptionTxt.Text + "','" + clientTxt.Text + "', 1,'"+ hoursTxt.Text + "')";
            search.ExecuteNonQuery();
            //search.CommandText = "insert into PROJECTS(PROJECT_ID, PROJECT_NAME, PROJECT_DESCRIPTION," +
            //  " PROJECT_CLIENT, PROJECT_BEGIN, PROJECT_END, PROJECT_STATUS, PROJECT_PAY_PER_HOUR ) values ('" + noTxt.Text + "','" + nameTxt.Text + "','" + descriptionTxt.Text + "','" + clientTxt.Text + "','" + beginDtp. + "','" + endDtp + "', 1, '" + hoursTxt.Text + "')";
            //search.ExecuteNonQuery();
            con.Close();
            // to here
        }
    }
}
