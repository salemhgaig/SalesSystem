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
    public partial class User_managment : Form
    {
       private void AutoSizegridview()
        {
            usersGrid.Width=this.Width;
            usersGrid.Height=this.Height;       
        }
        public User_managment()
        {
            InitializeComponent();
         
        }

        private void controlPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void User_managment_Resize(object sender, EventArgs e)
        {
         
            AutoSizegridview();
        }
    }
}
