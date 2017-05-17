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
    public partial class Taskss : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-97V1D5E\SQLEXPRESS;Initial Catalog=ProjectManagement;Integrated Security=True");

        public Taskss()
        {
            InitializeComponent();
        }

        public Taskss(string s)
        {
            InitializeComponent();
            label12.Text = s;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewProject srch = new NewProject();
            srch.Show();
            this.Hide();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand search = con.CreateCommand();
            search.CommandType = CommandType.Text;
            int i = 0;
            char m = 'M';
            search.CommandText = "insert into PROJECT_TASKS(TASK_ID, PROJECT_ID, EXPRET_ID, TASK_NAME, TASK_DESCRIPTION, " +
                "TAS_DELIVERABLES, TASK_PRIORITY," +
                " TASK_STATUS, TASK_READY, TASK_HOURS)" +
                " values (4,121,324453,'" + textBox2.Text + "','" + textBox2.Text + "','" + textBox1.Text + "','" + m +
                "', 1 , '" + textBox7.Text + "','" + textBox8.Text + "')";
            search.ExecuteNonQuery();

            con.Close();
            // to here
        }
    }
}
