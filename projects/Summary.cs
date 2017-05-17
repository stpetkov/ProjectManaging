using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projects
{
    public partial class Summary : Form
    {
        public Summary()
        {
            InitializeComponent();
        }

        public Summary(string s)
        {
            InitializeComponent();
            label4.Text = s;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            SearchProjects srch = new SearchProjects();
            srch.Show();
            this.Hide();
    
        }
    }
}
