using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesSystem
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Password.UseSystemPasswordChar = true; 
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (Password.UseSystemPasswordChar)
            {
                Password.UseSystemPasswordChar = false; 
                toolTip1.SetToolTip(pictureBox5, "إخفاء");
                pictureBox5.Image = Properties.Resources._7794218;
            }
            else
            {
                Password.UseSystemPasswordChar = true; 
                toolTip1.SetToolTip(pictureBox5, "إظهار");
               
                pictureBox5.Image = Properties.Resources._8395688;
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
