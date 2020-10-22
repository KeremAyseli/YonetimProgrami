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
        private void PdfGosterme_Load(object sender, EventArgs e)
        {
            try
            {
                axAcroPDF1.LoadFile(Environment.CurrentDirectory + @"\" + pdfYol + ".pdf");
                axAcroPDF1.src = Environment.CurrentDirectory + @"\" + pdfYol + ".pdf";
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
    }
}
