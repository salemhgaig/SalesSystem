using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SalesSystem
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

       

       
        private void Form_login_Resize(object sender, EventArgs e)
        {
            Utility.CenterPanel(panel1, this);
        }

       

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            if (Password.UseSystemPasswordChar)
            {
                Password.UseSystemPasswordChar = false; // إظهار كلمة المرور
                toolTip1.SetToolTip(pictureBox5, "إخفاء");
                pictureBox5.Image = Properties.Resources._7794218; // تغيير صورة العين (إظهار)
            }
            else
            {
                Password.UseSystemPasswordChar = true; // إخفاء كلمة المرور
                toolTip1.SetToolTip(pictureBox5, "إظهار");
                pictureBox5.Image = Properties.Resources._8395688; // تغيير صورة العين (إخفاء)
            }
        }

        private void Form_login_Load(object sender, EventArgs e)
        {
            Password.UseSystemPasswordChar = false;

        }
    }
    }

