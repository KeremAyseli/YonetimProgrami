using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace YönetimProgramı
{
    public partial class pdfBastırmaAyarEkranı : Form
    {
        public pdfBastırmaAyarEkranı()
        {
            InitializeComponent();
        }
        string DosyaYolu;
        ArayuzHareketleri arayuz = new ArayuzHareketleri();
        struct PdfAyarlar
        {
          public string DosyaYolu;
          public string ResimYolu;
          public string IsyeriIsmi;
          public string Adres;

        }
        PdfAyarlar ayar = new PdfAyarlar();
        public void JsonGüncelleme(string Sütunİsmi,string YeniVeri)
        {
            string json = File.ReadAllText(Environment.CurrentDirectory + @"\Ayarlar\ayar.json");
            dynamic dosya = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            dosya[Sütunİsmi] = YeniVeri;
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(dosya, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(Environment.CurrentDirectory + @"\Ayarlar\ayar.json", output);
        }
        private void button3_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                
                JsonGüncelleme("DosyaYolu", textBox1.Text);
            }
            if (checkBox2.Checked == true)
            {
                
                JsonGüncelleme("ResimYolu", DosyaYolu);
            }
            if (checkBox3.Checked == true)
            {
                
                JsonGüncelleme("IsyeriIsmi", textBox3.Text);
            }
            if (checkBox4.Checked == true)
            {
               
                JsonGüncelleme("Adres", textBox4.Text);
            }  
        }

        private void pdfBastırmaAyarEkranı_Load(object sender, EventArgs e)
        {
       
        }
        
        private void pdfBastırmaAyarEkranı_MouseDown(object sender, MouseEventArgs e)
        {
            arayuz.FormuSurukle(this, e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            arayuz.FormuSurukle(this, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            DosyaYolu = folderBrowserDialog1.SelectedPath;
        }
    }
}
