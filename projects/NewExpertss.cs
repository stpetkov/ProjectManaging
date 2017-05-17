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
    public partial class NewExpertss : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-97V1D5E\SQLEXPRESS;Initial Catalog=ProjectManagement;Integrated Security=True");
        public NewExpertss()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 srch = new Form1();
            srch.Show();
            this.Hide();
        }
        // from here there is new code
        


        int newId = 321233;
        private void saveBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand search = con.CreateCommand();
            search.CommandType = CommandType.Text;
            string IorE = "I";
            if (radioButton2.Checked)
            {
                IorE = "E";
            }
                search.CommandText = "insert into EXPERTS(EXPRET_ID, EXPERT_TYPE, EXPERT_NAME, EXPERT_SURNAME, EXPERT_LASTNAME) values ('" + newId + "','" + IorE + "','" + nameTxt.Text + "', '" + snameTxt.Text + "', '" + lnameTxt.Text + "')";
            search.ExecuteNonQuery();
            con.Close();
            
        }
        // to here 
        private void eXPERTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eXPERTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectManagementDataSet);

        }

        private void NewExpertss_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectManagementDataSet.EXPERTS' table. You can move, or remove it, as needed.
            //this.eXPERTSTableAdapter.Fill(this.projectManagementDataSet.EXPERTS);

        }

        private void sqlConnection1_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {

        }
    }
}
