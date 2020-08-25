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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {VeriTabanı vt = new VeriTabanı();
            EldekiUrun urunler = new EldekiUrun();
            // vt.Database.Create();
            // vt.Database.ExecuteSqlCommand("İnsert into EldekiUrun(ürünKod,ürünAdet,üretici) values('1203','100','Merhaba')");
            Console.WriteLine(  vt.EldekiUrun.SqlQuery("select * from EldekiUrun").FirstOrDefault().üretici);
            
           
               urunler.üretici = "AyseliKerem";
               urunler.ürünAdet = 100;
               urunler.ürünKod = 10102040;
            
            
            for (int i = 0; i < vt.EldekiUrun.ToList().Count; i++)
            {
                ListViewItem deger = new ListViewItem();
            deger.Text=vt.EldekiUrun.ToList()[i].ürünİd.ToString();
              deger.SubItems.Add(vt.EldekiUrun.ToList()[i].ürünKod.ToString());
               deger.SubItems.Add(vt.EldekiUrun.ToList()[i].üretici.ToString());
               deger.SubItems.Add(vt.EldekiUrun.ToList()[i].ürünAdet.ToString());
               Console.WriteLine(vt.EldekiUrun.ToList()[i].üretici.ToString());
                Console.WriteLine(vt.EldekiUrun.ToList()[i].ürünAdet.ToString());
                Console.WriteLine(vt.EldekiUrun.ToList()[i].ürünKod.ToString());
                Console.WriteLine(vt.EldekiUrun.ToList()[i].ürünİd.ToString());
              listView1.Items.Add(deger);
                
            }
            
            var veriler = from EldekiUrun in urunler.üretici select Üretici;

           
            
           
            
           
           vt.EldekiUrun.Add(urunler);
            vt.SaveChanges();

        }
    }
}
