using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YönetimProgramı
{
    public partial class PdfGosterme : Form
    {
        public PdfGosterme()
        {
            InitializeComponent();
        }
        public string pdfYol { get; set; }
        Ayarlar arayüz = new Ayarlar();
        private void PdfGosterme_Load(object sender, EventArgs e)
        {
            try
            {
                axAcroPDF1.LoadFile(arayüz.DosyaYoluGetir() + @"\" + pdfYol + ".pdf");
                axAcroPDF1.src = arayüz.DosyaYoluGetir() + @"\" + pdfYol + ".pdf";
                axAcroPDF1.printAll();
               
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }
    }
}
