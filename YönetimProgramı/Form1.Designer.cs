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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Ürünİd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ÜrünKod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Üretici = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
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
            this.GuncellemeId = new System.Windows.Forms.TextBox();
            this.GüncellemButonu = new System.Windows.Forms.Button();
            this.AdetGuncelleme = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SilmeButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SilmeTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.UrunFiyat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ürünİd,
            this.ÜrünKod,
            this.Üretici,
            this.Adet,
            this.Fiyat});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 281);
            this.listView1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1060, 222);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Ürünİd
            // 
            this.Ürünİd.Text = "Ürünİd";
            this.Ürünİd.Width = 120;
            // 
            // ÜrünKod
            // 
            this.ÜrünKod.Text = "ÜrünKod";
            this.ÜrünKod.Width = 120;
            // 
            // Üretici
            // 
            this.Üretici.Text = "Üretici";
            this.Üretici.Width = 120;
            // 
            // Adet
            // 
            this.Adet.Text = "Adet";
            this.Adet.Width = 120;
            // 
            // Fiyat
            // 
            this.Fiyat.Text = "Fİyat";
            this.Fiyat.Width = 81;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(920, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AramaUrunId
            // 
            this.AramaUrunId.Location = new System.Drawing.Point(951, 49);
            this.AramaUrunId.Name = "AramaUrunId";
            this.AramaUrunId.Size = new System.Drawing.Size(100, 20);
            this.AramaUrunId.TabIndex = 2;
            // 
            // UrunKodKayit
            // 
            this.UrunKodKayit.Location = new System.Drawing.Point(123, 46);
            this.UrunKodKayit.Name = "UrunKodKayit";
            this.UrunKodKayit.Size = new System.Drawing.Size(100, 20);
            this.UrunKodKayit.TabIndex = 3;
            // 
            // UreticiKayit
            // 
            this.UreticiKayit.Location = new System.Drawing.Point(123, 85);
            this.UreticiKayit.Name = "UreticiKayit";
            this.UreticiKayit.Size = new System.Drawing.Size(100, 20);
            this.UreticiKayit.TabIndex = 4;
            // 
            // AdetKayit
            // 
            this.AdetKayit.Location = new System.Drawing.Point(123, 122);
            this.AdetKayit.Name = "AdetKayit";
            this.AdetKayit.Size = new System.Drawing.Size(100, 20);
            this.AdetKayit.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(872, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ÜrünId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ÜrünKod";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Üretici";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Adet";
            // 
            // AramaButonu
            // 
            this.AramaButonu.Location = new System.Drawing.Point(961, 129);
            this.AramaButonu.Name = "AramaButonu";
            this.AramaButonu.Size = new System.Drawing.Size(75, 23);
            this.AramaButonu.TabIndex = 10;
            this.AramaButonu.Text = "Bul";
            this.AramaButonu.UseVisualStyleBackColor = true;
            this.AramaButonu.Click += new System.EventHandler(this.button2_Click);
            // 
            // KayıtGirmeButonu
            // 
            this.KayıtGirmeButonu.Location = new System.Drawing.Point(87, 203);
            this.KayıtGirmeButonu.Name = "KayıtGirmeButonu";
            this.KayıtGirmeButonu.Size = new System.Drawing.Size(75, 23);
            this.KayıtGirmeButonu.TabIndex = 11;
            this.KayıtGirmeButonu.Text = "Kayıt Gir";
            this.KayıtGirmeButonu.UseVisualStyleBackColor = true;
            this.KayıtGirmeButonu.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(872, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "ÜrünKod";
            // 
            // AramaUrunKod
            // 
            this.AramaUrunKod.Location = new System.Drawing.Point(951, 85);
            this.AramaUrunKod.Name = "AramaUrunKod";
            this.AramaUrunKod.Size = new System.Drawing.Size(100, 20);
            this.AramaUrunKod.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 48);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Id";
            // 
            // GuncellemeId
            // 
            this.GuncellemeId.Location = new System.Drawing.Point(382, 46);
            this.GuncellemeId.Name = "GuncellemeId";
            this.GuncellemeId.Size = new System.Drawing.Size(100, 20);
            this.GuncellemeId.TabIndex = 15;
            // 
            // GüncellemButonu
            // 
            this.GüncellemButonu.Location = new System.Drawing.Point(393, 124);
            this.GüncellemButonu.Name = "GüncellemButonu";
            this.GüncellemButonu.Size = new System.Drawing.Size(75, 23);
            this.GüncellemButonu.TabIndex = 16;
            this.GüncellemButonu.Text = "Güncelle";
            this.GüncellemButonu.UseVisualStyleBackColor = true;
            this.GüncellemButonu.Click += new System.EventHandler(this.GüncellemButonu_Click);
            // 
            // AdetGuncelleme
            // 
            this.AdetGuncelleme.Location = new System.Drawing.Point(384, 81);
            this.AdetGuncelleme.Name = "AdetGuncelleme";
            this.AdetGuncelleme.Size = new System.Drawing.Size(100, 20);
            this.AdetGuncelleme.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Adet";
            // 
            // SilmeButton
            // 
            this.SilmeButton.Location = new System.Drawing.Point(667, 74);
            this.SilmeButton.Name = "SilmeButton";
            this.SilmeButton.Size = new System.Drawing.Size(75, 23);
            this.SilmeButton.TabIndex = 19;
            this.SilmeButton.Text = "Sil";
            this.SilmeButton.UseVisualStyleBackColor = true;
            this.SilmeButton.Click += new System.EventHandler(this.SilmeButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(587, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Silinecek Id";
            // 
            // SilmeTextBox
            // 
            this.SilmeTextBox.Location = new System.Drawing.Point(655, 48);
            this.SilmeTextBox.Name = "SilmeTextBox";
            this.SilmeTextBox.Size = new System.Drawing.Size(100, 20);
            this.SilmeTextBox.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Listeyi Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(573, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "İrsaliye Bas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Fiyat";
            // 
            // UrunFiyat
            // 
            this.UrunFiyat.Location = new System.Drawing.Point(123, 158);
            this.UrunFiyat.Name = "UrunFiyat";
            this.UrunFiyat.Size = new System.Drawing.Size(100, 20);
            this.UrunFiyat.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1082, 515);
            this.Controls.Add(this.UrunFiyat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SilmeTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SilmeButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AdetGuncelleme);
            this.Controls.Add(this.GüncellemButonu);
            this.Controls.Add(this.GuncellemeId);
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Ürünİd;
        private System.Windows.Forms.ColumnHeader ÜrünKod;
        private System.Windows.Forms.ColumnHeader Üretici;
        private System.Windows.Forms.ColumnHeader Adet;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.TextBox GuncellemeId;
        private System.Windows.Forms.Button GüncellemButonu;
        private System.Windows.Forms.TextBox AdetGuncelleme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SilmeButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SilmeTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox UrunFiyat;
        private System.Windows.Forms.ColumnHeader Fiyat;
    }
}

