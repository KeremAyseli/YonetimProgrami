namespace YönetimProgramı
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.Ürünİd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ÜrünKod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Üretici = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AramaUrunId = new System.Windows.Forms.TextBox();
            this.UrunKodKayit = new System.Windows.Forms.TextBox();
            this.UreticiKayit = new System.Windows.Forms.TextBox();
            this.AdetKayit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AramaButonu = new System.Windows.Forms.Button();
            this.KayıtGirmeButonu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.AramaUrunKod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IdGüncelleme = new System.Windows.Forms.TextBox();
            this.GüncellemButonu = new System.Windows.Forms.Button();
            this.AdetGuncelleme = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SilmeButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SilmeTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.UrunFiyat = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.ÜreticiGüncelleme = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.FiyatGüncelleme = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ürünİd,
            this.ÜrünKod,
            this.Üretici,
            this.Adet,
            this.Fiyat});
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Ürünİd
            // 
            resources.ApplyResources(this.Ürünİd, "Ürünİd");
            // 
            // ÜrünKod
            // 
            resources.ApplyResources(this.ÜrünKod, "ÜrünKod");
            // 
            // Üretici
            // 
            resources.ApplyResources(this.Üretici, "Üretici");
            // 
            // Adet
            // 
            resources.ApplyResources(this.Adet, "Adet");
            // 
            // Fiyat
            // 
            resources.ApplyResources(this.Fiyat, "Fiyat");
            // 
            // AramaUrunId
            // 
            this.AramaUrunId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.AramaUrunId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.AramaUrunId, "AramaUrunId");
            this.AramaUrunId.ForeColor = System.Drawing.Color.White;
            this.AramaUrunId.Name = "AramaUrunId";
            // 
            // UrunKodKayit
            // 
            this.UrunKodKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.UrunKodKayit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.UrunKodKayit, "UrunKodKayit");
            this.UrunKodKayit.ForeColor = System.Drawing.Color.White;
            this.UrunKodKayit.Name = "UrunKodKayit";
            // 
            // UreticiKayit
            // 
            this.UreticiKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.UreticiKayit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.UreticiKayit, "UreticiKayit");
            this.UreticiKayit.ForeColor = System.Drawing.Color.White;
            this.UreticiKayit.Name = "UreticiKayit";
            // 
            // AdetKayit
            // 
            this.AdetKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.AdetKayit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.AdetKayit, "AdetKayit");
            this.AdetKayit.ForeColor = System.Drawing.Color.White;
            this.AdetKayit.Name = "AdetKayit";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // AramaButonu
            // 
            this.AramaButonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            resources.ApplyResources(this.AramaButonu, "AramaButonu");
            this.AramaButonu.ForeColor = System.Drawing.Color.White;
            this.AramaButonu.Name = "AramaButonu";
            this.AramaButonu.UseVisualStyleBackColor = false;
            this.AramaButonu.Click += new System.EventHandler(this.button2_Click);
            // 
            // KayıtGirmeButonu
            // 
            this.KayıtGirmeButonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            resources.ApplyResources(this.KayıtGirmeButonu, "KayıtGirmeButonu");
            this.KayıtGirmeButonu.ForeColor = System.Drawing.Color.White;
            this.KayıtGirmeButonu.Name = "KayıtGirmeButonu";
            this.KayıtGirmeButonu.UseVisualStyleBackColor = false;
            this.KayıtGirmeButonu.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // AramaUrunKod
            // 
            this.AramaUrunKod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.AramaUrunKod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.AramaUrunKod, "AramaUrunKod");
            this.AramaUrunKod.ForeColor = System.Drawing.Color.White;
            this.AramaUrunKod.Name = "AramaUrunKod";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // IdGüncelleme
            // 
            this.IdGüncelleme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.IdGüncelleme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.IdGüncelleme, "IdGüncelleme");
            this.IdGüncelleme.ForeColor = System.Drawing.Color.White;
            this.IdGüncelleme.Name = "IdGüncelleme";
            // 
            // GüncellemButonu
            // 
            this.GüncellemButonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            resources.ApplyResources(this.GüncellemButonu, "GüncellemButonu");
            this.GüncellemButonu.ForeColor = System.Drawing.Color.White;
            this.GüncellemButonu.Name = "GüncellemButonu";
            this.GüncellemButonu.UseVisualStyleBackColor = false;
            this.GüncellemButonu.Click += new System.EventHandler(this.GüncellemButonu_Click);
            // 
            // AdetGuncelleme
            // 
            this.AdetGuncelleme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.AdetGuncelleme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.AdetGuncelleme, "AdetGuncelleme");
            this.AdetGuncelleme.ForeColor = System.Drawing.Color.White;
            this.AdetGuncelleme.Name = "AdetGuncelleme";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // SilmeButton
            // 
            this.SilmeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            resources.ApplyResources(this.SilmeButton, "SilmeButton");
            this.SilmeButton.ForeColor = System.Drawing.Color.White;
            this.SilmeButton.Name = "SilmeButton";
            this.SilmeButton.UseVisualStyleBackColor = false;
            this.SilmeButton.Click += new System.EventHandler(this.SilmeButton_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // SilmeTextBox
            // 
            this.SilmeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.SilmeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.SilmeTextBox, "SilmeTextBox");
            this.SilmeTextBox.ForeColor = System.Drawing.Color.White;
            this.SilmeTextBox.Name = "SilmeTextBox";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // UrunFiyat
            // 
            this.UrunFiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.UrunFiyat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.UrunFiyat, "UrunFiyat");
            this.UrunFiyat.ForeColor = System.Drawing.Color.White;
            this.UrunFiyat.Name = "UrunFiyat";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(117)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.button4, "button4");
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(92)))));
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.MouseEnter += new System.EventHandler(this.button5_MouseEnter);
            this.button5.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(19)))));
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            resources.ApplyResources(this.button3, "button3");
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // ÜreticiGüncelleme
            // 
            this.ÜreticiGüncelleme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.ÜreticiGüncelleme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.ÜreticiGüncelleme, "ÜreticiGüncelleme");
            this.ÜreticiGüncelleme.ForeColor = System.Drawing.Color.White;
            this.ÜreticiGüncelleme.Name = "ÜreticiGüncelleme";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // FiyatGüncelleme
            // 
            this.FiyatGüncelleme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(107)))));
            this.FiyatGüncelleme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.FiyatGüncelleme, "FiyatGüncelleme");
            this.FiyatGüncelleme.ForeColor = System.Drawing.Color.White;
            this.FiyatGüncelleme.Name = "FiyatGüncelleme";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.label11);
            this.Controls.Add(this.FiyatGüncelleme);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ÜreticiGüncelleme);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UrunFiyat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SilmeTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SilmeButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AdetGuncelleme);
            this.Controls.Add(this.GüncellemButonu);
            this.Controls.Add(this.IdGüncelleme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AramaUrunKod);
            this.Controls.Add(this.KayıtGirmeButonu);
            this.Controls.Add(this.AramaButonu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdetKayit);
            this.Controls.Add(this.UreticiKayit);
            this.Controls.Add(this.UrunKodKayit);
            this.Controls.Add(this.AramaUrunId);
            this.Controls.Add(this.listView1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Ürünİd;
        private System.Windows.Forms.ColumnHeader ÜrünKod;
        private System.Windows.Forms.ColumnHeader Üretici;
        private System.Windows.Forms.ColumnHeader Adet;
        private System.Windows.Forms.TextBox AramaUrunId;
        private System.Windows.Forms.TextBox UrunKodKayit;
        private System.Windows.Forms.TextBox UreticiKayit;
        private System.Windows.Forms.TextBox AdetKayit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AramaButonu;
        private System.Windows.Forms.Button KayıtGirmeButonu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AramaUrunKod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IdGüncelleme;
        private System.Windows.Forms.Button GüncellemButonu;
        private System.Windows.Forms.TextBox AdetGuncelleme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SilmeButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SilmeTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox UrunFiyat;
        private System.Windows.Forms.ColumnHeader Fiyat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ÜreticiGüncelleme;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox FiyatGüncelleme;
    }
}

