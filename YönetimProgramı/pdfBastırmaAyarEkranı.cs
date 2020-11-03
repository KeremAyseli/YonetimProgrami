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
        string resimDosyaYolu;
        Ayarlar arayuz = new Ayarlar();
       
        
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
                
                JsonGüncelleme("DosyaYolu", DosyaYolu);
            }
            if (checkBox2.Checked == true)
            {
                
                JsonGüncelleme("ResimYolu", resimDosyaYolu);
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
        {openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                resimDosyaYolu = openFileDialog1.FileName.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            DosyaYolu = folderBrowserDialog1.SelectedPath;
        }
    }
}
