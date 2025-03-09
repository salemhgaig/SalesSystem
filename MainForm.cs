using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;

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

            // تطبيق الخط على عناصر الواجهة
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

   
    }
}
