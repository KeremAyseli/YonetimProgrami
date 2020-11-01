using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Diagnostics;
using Microsoft.Win32;

namespace YönetimProgramı
{
    public partial class İrsaliyeBasmaEkranı : Form
    {
        public İrsaliyeBasmaEkranı()
        {
            InitializeComponent();
        }
        ArayuzHareketleri arayüz = new ArayuzHareketleri();
        List<EldekiUrun> eldekiürünler=new List<EldekiUrun>();
        int toplamFiyat = 0;
        VeriTabanı vt = new VeriTabanı();
        public string yolPdf { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text)==false)
            {
                yolPdf = textBox1.Text;

                DökümanOlusturma(textBox1.Text, eldekiürünler, toplamFiyat);

                if (AdobeKontrol() == true)
                {
                    PdfGosterme form2 = new PdfGosterme();
                    form2.pdfYol = textBox1.Text;
                    form2.Show();
                }
                else
                {
                    Process islem = new Process();
                    islem.StartInfo = new ProcessStartInfo()
                    {
                        FileName = Environment.CurrentDirectory + @"\" + textBox1.Text + ".pdf"
                    };
                    islem.Start();
                }
            }
            else
            {
                MessageBox.Show("Lütfen İrsaliye numarası veya ismi giriniz");
            }

        }
        private void DökümanOlusturma(string pdfİsmi, List<EldekiUrun> kimlik, int toplamfiyat)
        {
            using (System.IO.FileStream bellek = new System.IO.FileStream(@"./" + pdfİsmi + ".pdf", System.IO.FileMode.OpenOrCreate))
            {
                Document döküman = new Document(PageSize.A4, 10, 10, 10, 10);
                PdfWriter yazıcı = PdfWriter.GetInstance(döküman, bellek);

                döküman.Open();

                Chunk chunk = new Chunk("bu ne 1");
                chunk.SetUnderline(150f, 150f);

                Paragraph paragraf = new Paragraph();
                paragraf.Add("MERHABA BU PARAGRAF DENEMESI");
                Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
                Paragraph baslik = new Paragraph(new Phrase("               Ürün Açıklama                                                                  Ürün Adet                       ürün fiyat"));
                Paragraph fiyat = new Paragraph(new Phrase("Toplam Fiyat: " + toplamFiyat + "TL"));
                fiyat.Alignment = Element.ALIGN_RIGHT;
                döküman.Add(paragraf);
                döküman.Add(chunk);
                döküman.Add(baslik);
                döküman.Add(p);
                Random rastgele = new Random();
                for (int i = 0; i < kimlik.Count; i++)
                { döküman.Add(hücre(kimlik[i].ürünKod.ToString(), kimlik[i].fiyat + " TL", kimlik[i].ürünAdet)); Console.WriteLine(kimlik[i].ürünAdet + "    " + kimlik[i].fiyat); }
                döküman.Add(p);
                döküman.Add(fiyat);

                döküman.Close();
                yazıcı.Close();
                bellek.Close();
            }

        }


        private IElement hücre(string yazılacakMetin)
        {
            PdfPTable tablo = new PdfPTable(1);
            PdfPCell hücre = new PdfPCell(new Phrase(yazılacakMetin));
            hücre.Border = 0;
            hücre.ExtraParagraphSpace = 1;
            hücre.HorizontalAlignment = 0;
            tablo.HeaderRows = 2;

            tablo.AddCell(hücre);
            return tablo;
        }
        private IElement hücre(string yazılacakMetin, string fiyat, int adet)
        {
            PdfPTable tablo = new PdfPTable(3);
            PdfPCell hücre = new PdfPCell(new Phrase(yazılacakMetin));
            PdfPCell hücre2 = new PdfPCell(new Phrase(fiyat));
            PdfPCell hücre3 = new PdfPCell(new Phrase(adet.ToString()));
            float[] width = new float[] { 10f, 10f, 10f };


            tablo.SetWidths(width);
            hücre.Border = 0;
            hücre.ExtraParagraphSpace = 1;
            hücre.HorizontalAlignment = 0;
            hücre.VerticalAlignment = PdfPCell.ALIGN_LEFT;
            hücre2.Border = 0;
            hücre2.ExtraParagraphSpace = 1;
            hücre2.HorizontalAlignment = 2;
            hücre2.PaddingLeft = 20f;
            hücre2.VerticalAlignment = PdfPCell.ALIGN_RIGHT;
            hücre3.Border = 0;
            hücre3.ExtraParagraphSpace = 1;
            hücre3.HorizontalAlignment = 2;
            hücre3.VerticalAlignment = PdfPCell.ALIGN_LEFT;
            tablo.AddCell(hücre);
            tablo.AddCell(hücre3);
            tablo.AddCell(hücre2);
            return tablo;
        }

        public bool AdobeKontrol()
        {
            RegistryKey ado = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Adobe");
            if (ado != null)
            {
                RegistryKey adoRead = ado.OpenSubKey("Acrobat Reader");
                if (adoRead != null)
                {
                    return true;
                }

            }
            return false;
        }

        private void button3_Click(object sender, EventArgs e)
        {EldekiUrun ürün = new EldekiUrun();

            if (String.IsNullOrEmpty(ÜrünAdet.Text)==false && String.IsNullOrEmpty(ÜrünKod.Text)==false)
            {
                int deger = Convert.ToInt32(ÜrünKod.Text);
                var veriler = vt.EldekiUrun.Where(r => r.ürünKod == deger).ToList();

                try
                {

                    int eldeOlanÜrün = veriler[0].ürünAdet;
                    try
                    {
                        ürün.ürünKod = Convert.ToInt32(ÜrünKod.Text);
                        ürün.fiyat = veriler[0].fiyat;
                        ürün.ürünAdet = Convert.ToInt32(ÜrünAdet.Text);
                        listBox1.Items.Add(ÜrünKod.Text + " Bu kodlu üründen," + ÜrünAdet.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("İstenen miktarda ürün mevcut değil.Elde olan ürün sayısı: " + eldeOlanÜrün.ToString()+"\n"+ex.Message);
                    }
                    toplamFiyat += (veriler[0].fiyat * ürün.ürünAdet);
                    eldekiürünler.Add(ürün);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Girilen kodla eşleşen ürün bulunmamakta." + ex.Message);

                }
            }
            else
            {
                MessageBox.Show("Eksik bilgi girdiniz");
            }
           
        }

        private void İrsaliyeOku_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text)==false)
            {
                if (AdobeKontrol() == true)
                {
                    PdfGosterme form2 = new PdfGosterme();
                    form2.pdfYol = textBox1.Text;
                    form2.Show();
                }
                else
                {
                    Process islem = new Process();
                    islem.StartInfo = new ProcessStartInfo()
                    {
                        FileName = Environment.CurrentDirectory + @"\" + textBox1.Text + ".pdf"
                    };
                    islem.Start();
                }
            }
            else
            {
                MessageBox.Show("Lütfen İrsaliye numarası veya ismi giriniz");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pdfBastırmaAyarEkranı ayarEkranı = new pdfBastırmaAyarEkranı();
            ayarEkranı.Show();
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void İrsaliyeBasmaEkranı_MouseDown(object sender, MouseEventArgs e)
        {
            arayüz.FormuSurukle(this, e);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            arayüz.FormuSurukle(this, e);
        }

        private void İrsaliyeBasmaEkranı_Load(object sender, EventArgs e)
        {

        }
    }
}
