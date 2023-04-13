using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_workshop
{
    public partial class Page1 : Form
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Page1_Load(object sender, EventArgs e)
        {
            label1.ForeColor = ColorTranslator.FromHtml("#6ee7b7");
            guna2Button1.FillColor = ColorTranslator.FromHtml("#34d399");
            label2.ForeColor = ColorTranslator.FromHtml("#616161");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}
