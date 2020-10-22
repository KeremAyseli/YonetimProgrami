﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YönetimProgramı
{
    public partial class Form1 : Form
    {
        VeriTabanı vt = new VeriTabanı();
        EldekiUrun urunler = new EldekiUrun();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < vt.EldekiUrun.ToList().Count; i++)
            {
                ListViewItem deger = new ListViewItem();
                deger.Text = vt.EldekiUrun.ToList()[i].ürünİd.ToString();
                deger.SubItems.Add(vt.EldekiUrun.ToList()[i].ürünKod.ToString());
                deger.SubItems.Add(vt.EldekiUrun.ToList()[i].üretici.ToString());
                deger.SubItems.Add(vt.EldekiUrun.ToList()[i].ürünAdet.ToString());
                deger.SubItems.Add(vt.EldekiUrun.ToList()[i].fiyat.ToString());
                Console.WriteLine(vt.EldekiUrun.ToList()[i].üretici.ToString());
                Console.WriteLine(vt.EldekiUrun.ToList()[i].ürünAdet.ToString());
                Console.WriteLine(vt.EldekiUrun.ToList()[i].ürünKod.ToString());
                Console.WriteLine(vt.EldekiUrun.ToList()[i].ürünİd.ToString());
                Console.WriteLine(vt.EldekiUrun.ToList()[i].fiyat.ToString());
                listView1.Items.Add(deger);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

            urunler.üretici = UreticiKayit.Text; 
            urunler.ürünAdet = Convert.ToInt32(AdetKayit.Text);
            urunler.ürünKod =Convert.ToInt32(UrunKodKayit.Text);
            urunler.fiyat = Convert.ToInt32(UrunFiyat.Text);
            vt.EldekiUrun.Add(urunler);
            vt.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(AramaUrunId.Text)==false)
            { int deger = Convert.ToInt32(AramaUrunId.Text);var veriler = vt.EldekiUrun.Where(r => r.ürünİd == deger).ToList(); Sorgu(veriler,listView1,Color.Red); } 
            if (string.IsNullOrEmpty(AramaUrunKod.Text)==false)
            { int deger = Convert.ToInt32(AramaUrunKod.Text); var veriler = vt.EldekiUrun.Where(r => r.ürünKod == deger).ToList(); Sorgu(veriler,listView1,Color.Blue); }      

        }
       
        private void Sorgu(List<EldekiUrun> veriler,ListView listView, Color renk)
        {
 

            Console.WriteLine("metot çalıştı");
            
            for (int i = 0; i < veriler.Count; i++)
            {
                ListViewItem GelenDegerler = new ListViewItem();
                GelenDegerler.Text = veriler[i].ürünİd.ToString();
                GelenDegerler.SubItems.Add(veriler[i].ürünKod.ToString());
                GelenDegerler.SubItems.Add(veriler[i].üretici.ToString());
                GelenDegerler.SubItems.Add(veriler[i].ürünAdet.ToString());
                GelenDegerler.SubItems.Add(veriler[i].fiyat.ToString());

                listView.Items.Add(GelenDegerler); listView.ForeColor = renk;
            }
        }

        private void GüncellemButonu_Click(object sender, EventArgs e)
        {
            int guncellemeId =Convert.ToInt32( GuncellemeId.Text);
            var güncelle = vt.EldekiUrun.First(r => r.ürünİd == guncellemeId);
            güncelle.ürünAdet=Convert.ToInt32(AdetGuncelleme.Text);
            vt.SaveChanges();
        }

        private void SilmeButton_Click(object sender, EventArgs e)
        {
            int silmeId = Convert.ToInt32(SilmeTextBox.Text);
            vt.EldekiUrun.Remove(vt.EldekiUrun.Single(r => r.ürünİd == silmeId));
            vt.SaveChanges();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            İrsaliyeBasmaEkranı form = new İrsaliyeBasmaEkranı();
            form.Show();
            
        }
    }
}
