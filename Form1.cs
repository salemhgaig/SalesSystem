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
    public partial class Face_login : Form
    {
        public Face_login()
        {
            InitializeComponent();
        }
        bool ShowTheCode = true;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
 
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (ShowTheCode)
            {

                toolTip1.SetToolTip(pictureBox5, "اخفاء");
                textBox1.PasswordChar = ' ';
                ShowTheCode = false;
                pictureBox5.Image = Properties.Resources._8395688;


            }
        
         else
            {

                toolTip1.SetToolTip(pictureBox5, "اظهار");
                ShowTheCode = true;
                pictureBox5.Image = Properties.Resources._7794218;
                textBox1.PasswordChar = '*';
            }
        }
    }
}
