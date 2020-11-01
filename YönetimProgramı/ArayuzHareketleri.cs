using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YönetimProgramı
{
    class ArayuzHareketleri
    {
        public const int WM_NCLBUTTONDOWN = 0XA1;
        public const int HT_CAPTION = 0X2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int ReleaseCapture();
        
        public void FormuSurukle(Form ekran,MouseEventArgs e) 
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(ekran.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }
        
    }
}
