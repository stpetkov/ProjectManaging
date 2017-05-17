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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void регистрацияНаНовПроектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProject srch = new NewProject();
            srch.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void търсенеНаПроектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchProjects srch = new SearchProjects();
            srch.Show();
            this.Hide();
        }

        private void регистрацияНаЕкспертиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewExpertss srch = new NewExpertss();
            srch.Show();
            this.Hide();
        }

        private void търсенеНаЕкспертToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchExpert srch = new SearchExpert();
            srch.Show();
            this.Hide();
        }
    }
}
