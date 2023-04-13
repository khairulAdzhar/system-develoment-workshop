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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.ForeColor = ColorTranslator.FromHtml("#6ee7b7");
            guna2Button1.FillColor = ColorTranslator.FromHtml("#34d399");
            guna2Button2.FillColor = ColorTranslator.FromHtml("#047857");
            guna2TextBox1.BorderColor = ColorTranslator.FromHtml("#6ee7b7");
            guna2TextBox2.BorderColor = ColorTranslator.FromHtml("#6ee7b7");
            guna2TextBox2.BorderThickness = 2;
            guna2TextBox1.BorderThickness = 2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Page1 l = new Page1();
            l.Show();
            this.Hide();
        }
    }
}
