﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace SalesSystem
{
    public partial class MainForm : Form
    {
     
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);

        private PrivateFontCollection pfc = new PrivateFontCollection();

        public MainForm()
        {
            InitializeComponent();
            LoadCustomFont();
           

        }

        private void LoadCustomFont()
        {
            // تحميل الخط من الموارد
            byte[] fontArray = Properties.Resources.DS_DIGIB; // استبدل YourFontName باسم ملف الخط
            int dataLength = fontArray.Length;

            IntPtr fontPtr = Marshal.AllocCoTaskMem(dataLength);
            Marshal.Copy(fontArray, 0, fontPtr, dataLength);

            uint cFonts = 0;
            AddFontMemResourceEx(fontPtr, (uint)dataLength, IntPtr.Zero, ref cFonts);

            pfc.AddMemoryFont(fontPtr, dataLength);
            Marshal.FreeCoTaskMem(fontPtr);

            Total_textBox.Font = new Font(pfc.Families[0], 19, FontStyle.Bold); // يمكنك تغيير الحجم
            Discount_textBox.Font = new Font(pfc.Families[0], 19, FontStyle.Bold);
            Net_textBox.Font = new Font(pfc.Families[0], 19, FontStyle.Bold);
        }
     
        private void MainForm_Load(object sender, EventArgs e)
        {
         
        }

        private void PrintInvoice_Btn_Click(object sender, EventArgs e)
        {
        }

        private void NewInvoice_Btn_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxSearchProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Discount_textBox_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void Discount_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }

            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            
            if (e.KeyChar == '.' && (Discount_textBox.Text.Contains(".")))
            {
                e.Handled = true;
            }
        }

        private void ادارةالموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void قائمةالديونToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fmimpure F= new Fmimpure();
            F.ShowDialog();
        }
    }
}
