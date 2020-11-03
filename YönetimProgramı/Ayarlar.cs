using System;
using System.IO;
using System.Windows.Forms;

namespace YönetimProgramı
{
    class Ayarlar
    {
        public const int WM_NCLBUTTONDOWN = 0XA1;
        public const int HT_CAPTION = 0X2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int ReleaseCapture();

       public struct PdfAyarlar
        {
            public string DosyaYolu { get; set; }
            public string ResimYolu { get; set; }
            public string IsyeriIsmi { get; set; }
            public string Adres { get; set; }

        }
        public void FormuSurukle(Form ekran,MouseEventArgs e) 
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(ekran.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }
        public string DosyaYoluGetir()
        {
            string yol= File.ReadAllText(Environment.CurrentDirectory + @"\Ayarlar\ayar.json");
            var jsonDosya= Newtonsoft.Json.JsonConvert.DeserializeObject<PdfAyarlar>(yol);
            return jsonDosya.DosyaYolu;
        }
        public string ResimYoluGetir()
        {
            string yol = File.ReadAllText(Environment.CurrentDirectory + @"\Ayarlar\ayar.json");
            var jsonDosya = Newtonsoft.Json.JsonConvert.DeserializeObject<PdfAyarlar>(yol);
            return jsonDosya.ResimYolu;
        }
        public string IsyeriIsmıGetir()
        {
            string yol = File.ReadAllText(Environment.CurrentDirectory + @"\Ayarlar\ayar.json");
            var jsonDosya = Newtonsoft.Json.JsonConvert.DeserializeObject<PdfAyarlar>(yol);
            return jsonDosya.IsyeriIsmi;
        }
        public string AdresGetir()
        {
            string yol = File.ReadAllText(Environment.CurrentDirectory + @"\Ayarlar\ayar.json");
            var jsonDosya = Newtonsoft.Json.JsonConvert.DeserializeObject<PdfAyarlar>(yol);
            return jsonDosya.Adres;
        }
        
    }
}
