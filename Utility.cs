using System;
using System.Windows.Forms;

namespace SalesSystem
{
    public static class Utility
    {
        public static void CenterPanel(Panel panel, Form form)
        {
            if (panel != null)
            {
                panel.Left = (form.ClientSize.Width - panel.Width) / 2;
                panel.Top = (form.ClientSize.Height - panel.Height) / 2;
            }
        }
    }
}
