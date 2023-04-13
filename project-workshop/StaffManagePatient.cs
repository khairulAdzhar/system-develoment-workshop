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
    public partial class StaffManagePatient : Form
    {
        public StaffManagePatient()
        {
            InitializeComponent();
        }

        private void StaffManagePatient_Load(object sender, EventArgs e)
        {
            //for left menu
            guna2Panel2.BackColor = ColorTranslator.FromHtml("#d1fae5");
            guna2PictureBox1.BackColor = ColorTranslator.FromHtml("#d1fae5");
            label1.BackColor = ColorTranslator.FromHtml("#d1fae5");
            guna2Button1.FillColor = ColorTranslator.FromHtml("#34d399");
            guna2Button2.FillColor = ColorTranslator.FromHtml("#d1fae5");
            guna2Button3.FillColor = ColorTranslator.FromHtml("#d1fae5");
            guna2Button4.FillColor = ColorTranslator.FromHtml("#d1fae5");
            guna2Button5.FillColor = ColorTranslator.FromHtml("#d1fae5");
            guna2PictureBox2.FillColor = ColorTranslator.FromHtml("#d1fae5");
            guna2PictureBox1.BackColor = ColorTranslator.FromHtml("#d1fae5");

            //button add and reset
            guna2Button7.FillColor = ColorTranslator.FromHtml("#34d399");
            guna2Button6.FillColor = ColorTranslator.FromHtml("#047857");
            guna2Button8.FillColor = ColorTranslator.FromHtml("#f87171");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {

        }
    }
}
