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
    public partial class SearchProjects : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-97V1D5E\SQLEXPRESS;Initial Catalog=ProjectManagement;Integrated Security=True");
        int status = 6;
        public SearchProjects()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

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
            
                if (statusCmb.SelectedIndex == 0)
                {
                    status = 1;
                }
                else if (statusCmb.SelectedIndex == 1)
                {
                    status = 2;
                }
                else if (statusCmb.SelectedIndex == 2)
                {
                    status = 3;
                }
                else if (statusCmb.SelectedIndex == 3)
                {
                    status = 4;
                }
                else if (statusCmb.SelectedIndex == 4)
                {
                    status = 5;
                }
                else if(statusCmb.SelectedIndex==5)
                {
                    status = 6;
                }



                SqlCommand search = con.CreateCommand();
            if (status == 6) {
                search.CommandType = CommandType.Text;
                search.CommandText = @"SELECT PROJECT_ID, PROJECT_NAME, PROJECT_CLIENT, PROJECT_BEGIN, PROJECT_END, PROJECT_STATUS
                                   FROM PROJECTS
                                   WHERE PROJECT_ID like '%" + noTxt.Text + "' AND PROJECT_NAME like '%" + nameTxt.Text + "%' AND PROJECT_CLIENT like '%" + clientTxt.Text + "%'";
            }
            if (status != 6)
            {

                search.CommandType = CommandType.Text;


                search.CommandText = @"SELECT PROJECT_ID, PROJECT_NAME, PROJECT_CLIENT, PROJECT_BEGIN, PROJECT_END, PROJECT_STATUS
                                   FROM PROJECTS
                                   WHERE PROJECT_ID like '%" + noTxt.Text + "' AND PROJECT_NAME like '%" + nameTxt.Text + "%' AND PROJECT_CLIENT like '%" + clientTxt.Text + "%'  AND PROJECT_STATUS like '%" + status + "%'";
            }
                search.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(search);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            
        }

        private void summaryBtn_Click(object sender, EventArgs e)
        {
            Summary srch = new Summary(nameTxt.Text);
            srch.Show();
            
        }

        private void statusCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
