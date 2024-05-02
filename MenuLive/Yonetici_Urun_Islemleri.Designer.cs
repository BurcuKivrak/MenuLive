
namespace MenuLive
{
    partial class Yonetici_Urun_Islemleri
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_urun_ekle = new System.Windows.Forms.Button();
            this.txt_urun_ad = new System.Windows.Forms.TextBox();
            this.urun_guncelle_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_urun_aciklama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_urun_fiyati = new System.Windows.Forms.TextBox();
            this.txt_urun_artis = new System.Windows.Forms.TextBox();
            this.txt_urun_azalis = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.resim_sec = new System.Windows.Forms.Button();
            this.resim_txt = new System.Windows.Forms.TextBox();
            this.lv_Urunler = new System.Windows.Forms.ListView();
            this.urun_ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kategori_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fiyat_guncel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.artis_yuzdesi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.azalis_yuzdesi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fiyat_max = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fiyat_min = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urun_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.min_fiyat_txt = new System.Windows.Forms.Label();
            this.max_fiyat_txt = new System.Windows.Forms.TextBox();
            this.urun_fiyat_min = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ktg_id_txt = new System.Windows.Forms.TextBox();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÜRÜNLER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_urun_ekle
            // 
            this.btn_urun_ekle.Location = new System.Drawing.Point(110, 525);
            this.btn_urun_ekle.Name = "btn_urun_ekle";
            this.btn_urun_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_urun_ekle.TabIndex = 1;
            this.btn_urun_ekle.Text = "Ekle";
            this.btn_urun_ekle.UseVisualStyleBackColor = true;
            this.btn_urun_ekle.Click += new System.EventHandler(this.btn_urun_ekle_Click);
            // 
            // txt_urun_ad
            // 
            this.txt_urun_ad.Location = new System.Drawing.Point(247, 93);
            this.txt_urun_ad.Name = "txt_urun_ad";
            this.txt_urun_ad.Size = new System.Drawing.Size(138, 22);
            this.txt_urun_ad.TabIndex = 2;
            // 
            // urun_guncelle_btn
            // 
            this.urun_guncelle_btn.Location = new System.Drawing.Point(349, 525);
            this.urun_guncelle_btn.Name = "urun_guncelle_btn";
            this.urun_guncelle_btn.Size = new System.Drawing.Size(93, 23);
            this.urun_guncelle_btn.TabIndex = 1;
            this.urun_guncelle_btn.Text = "Güncelle";
            this.urun_guncelle_btn.UseVisualStyleBackColor = true;
            this.urun_guncelle_btn.Click += new System.EventHandler(this.urun_guncelle_btn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(237, 525);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_urun_aciklama
            // 
            this.txt_urun_aciklama.Location = new System.Drawing.Point(247, 219);
            this.txt_urun_aciklama.Name = "txt_urun_aciklama";
            this.txt_urun_aciklama.Size = new System.Drawing.Size(138, 22);
            this.txt_urun_aciklama.TabIndex = 2;
            this.txt_urun_aciklama.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adı";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün Görseli:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ürün Fiyatı:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ürün Artış Yüzdesi:";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ürün Azalış Yüzdesi:";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ürün Açıklama:";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_urun_fiyati
            // 
            this.txt_urun_fiyati.Location = new System.Drawing.Point(247, 266);
            this.txt_urun_fiyati.Name = "txt_urun_fiyati";
            this.txt_urun_fiyati.Size = new System.Drawing.Size(138, 22);
            this.txt_urun_fiyati.TabIndex = 2;
            this.txt_urun_fiyati.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_urun_artis
            // 
            this.txt_urun_artis.Location = new System.Drawing.Point(247, 349);
            this.txt_urun_artis.Name = "txt_urun_artis";
            this.txt_urun_artis.Size = new System.Drawing.Size(138, 22);
            this.txt_urun_artis.TabIndex = 2;
            this.txt_urun_artis.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_urun_azalis
            // 
            this.txt_urun_azalis.Location = new System.Drawing.Point(247, 392);
            this.txt_urun_azalis.Name = "txt_urun_azalis";
            this.txt_urun_azalis.Size = new System.Drawing.Size(138, 22);
            this.txt_urun_azalis.TabIndex = 2;
            this.txt_urun_azalis.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(415, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 70);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // resim_sec
            // 
            this.resim_sec.Location = new System.Drawing.Point(115, 163);
            this.resim_sec.Name = "resim_sec";
            this.resim_sec.Size = new System.Drawing.Size(46, 39);
            this.resim_sec.TabIndex = 5;
            this.resim_sec.Text = "Seç";
            this.resim_sec.UseVisualStyleBackColor = true;
            this.resim_sec.Click += new System.EventHandler(this.resim_sec_Click);
            // 
            // resim_txt
            // 
            this.resim_txt.Location = new System.Drawing.Point(247, 143);
            this.resim_txt.Name = "resim_txt";
            this.resim_txt.Size = new System.Drawing.Size(138, 22);
            this.resim_txt.TabIndex = 6;
            // 
            // lv_Urunler
            // 
            this.lv_Urunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.urun_id,
            this.kategori_id,
            this.urun_ad,
            this.fiyat_guncel,
            this.aciklama,
            this.artis_yuzdesi,
            this.azalis_yuzdesi,
            this.fiyat_max,
            this.fiyat_min});
            this.lv_Urunler.HideSelection = false;
            this.lv_Urunler.Location = new System.Drawing.Point(532, 93);
            this.lv_Urunler.Name = "lv_Urunler";
            this.lv_Urunler.Size = new System.Drawing.Size(748, 369);
            this.lv_Urunler.TabIndex = 7;
            this.lv_Urunler.UseCompatibleStateImageBehavior = false;
            this.lv_Urunler.View = System.Windows.Forms.View.Details;
            this.lv_Urunler.SelectedIndexChanged += new System.EventHandler(this.lv_Urunler_SelectedIndexChanged);
            // 
            // urun_ad
            // 
            this.urun_ad.Text = "Ürün Adı";
            this.urun_ad.Width = 68;
            // 
            // kategori_id
            // 
            this.kategori_id.Text = "Kategori ID";
            this.kategori_id.Width = 93;
            // 
            // fiyat_guncel
            // 
            this.fiyat_guncel.Text = "Güncel Fiyat";
            this.fiyat_guncel.Width = 119;
            // 
            // aciklama
            // 
            this.aciklama.Text = "Açıklama";
            this.aciklama.Width = 86;
            // 
            // artis_yuzdesi
            // 
            this.artis_yuzdesi.Text = "Artış Yüzdesi";
            this.artis_yuzdesi.Width = 99;
            // 
            // azalis_yuzdesi
            // 
            this.azalis_yuzdesi.Text = "Azalış Yüzdesi";
            this.azalis_yuzdesi.Width = 102;
            // 
            // fiyat_max
            // 
            this.fiyat_max.Text = "Max Fiyat";
            this.fiyat_max.Width = 76;
            // 
            // fiyat_min
            // 
            this.fiyat_min.Text = "Min Fiyat";
            this.fiyat_min.Width = 85;
            // 
            // urun_id
            // 
            this.urun_id.Text = "Ürün ID";
            this.urun_id.Width = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ürün Max Fiyat:";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // min_fiyat_txt
            // 
            this.min_fiyat_txt.AutoSize = true;
            this.min_fiyat_txt.Location = new System.Drawing.Point(109, 479);
            this.min_fiyat_txt.Name = "min_fiyat_txt";
            this.min_fiyat_txt.Size = new System.Drawing.Size(103, 17);
            this.min_fiyat_txt.TabIndex = 0;
            this.min_fiyat_txt.Text = "Ürün Min Fiyat:";
            this.min_fiyat_txt.Click += new System.EventHandler(this.label1_Click);
            // 
            // max_fiyat_txt
            // 
            this.max_fiyat_txt.Location = new System.Drawing.Point(247, 436);
            this.max_fiyat_txt.Name = "max_fiyat_txt";
            this.max_fiyat_txt.Size = new System.Drawing.Size(138, 22);
            this.max_fiyat_txt.TabIndex = 2;
            this.max_fiyat_txt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // urun_fiyat_min
            // 
            this.urun_fiyat_min.Location = new System.Drawing.Point(247, 479);
            this.urun_fiyat_min.Name = "urun_fiyat_min";
            this.urun_fiyat_min.Size = new System.Drawing.Size(138, 22);
            this.urun_fiyat_min.TabIndex = 2;
            this.urun_fiyat_min.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(247, 306);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(112, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ürün Kategori:";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // ktg_id_txt
            // 
            this.ktg_id_txt.Location = new System.Drawing.Point(396, 309);
            this.ktg_id_txt.Name = "ktg_id_txt";
            this.ktg_id_txt.Size = new System.Drawing.Size(19, 22);
            this.ktg_id_txt.TabIndex = 2;
            this.ktg_id_txt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(53, 570);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(75, 50);
            this.btn_geri.TabIndex = 9;
            this.btn_geri.Text = "Geri";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(163, 570);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(75, 50);
            this.btn_cikis.TabIndex = 9;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // Yonetici_Urun_Islemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 632);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lv_Urunler);
            this.Controls.Add(this.resim_txt);
            this.Controls.Add(this.resim_sec);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.urun_fiyat_min);
            this.Controls.Add(this.txt_urun_azalis);
            this.Controls.Add(this.max_fiyat_txt);
            this.Controls.Add(this.txt_urun_artis);
            this.Controls.Add(this.txt_urun_fiyati);
            this.Controls.Add(this.ktg_id_txt);
            this.Controls.Add(this.txt_urun_aciklama);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.urun_guncelle_btn);
            this.Controls.Add(this.txt_urun_ad);
            this.Controls.Add(this.btn_urun_ekle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.min_fiyat_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Yonetici_Urun_Islemleri";
            this.Text = "Yonetici_Urun_Islemleri";
            this.Load += new System.EventHandler(this.Yonetici_Urun_Islemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_urun_ekle;
        private System.Windows.Forms.TextBox txt_urun_ad;
        private System.Windows.Forms.Button urun_guncelle_btn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_urun_aciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_urun_fiyati;
        private System.Windows.Forms.TextBox txt_urun_artis;
        private System.Windows.Forms.TextBox txt_urun_azalis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button resim_sec;
        private System.Windows.Forms.TextBox resim_txt;
        private System.Windows.Forms.ListView lv_Urunler;
        private System.Windows.Forms.ColumnHeader kategori_id;
        private System.Windows.Forms.ColumnHeader urun_ad;
        private System.Windows.Forms.ColumnHeader fiyat_guncel;
        private System.Windows.Forms.ColumnHeader aciklama;
        private System.Windows.Forms.ColumnHeader artis_yuzdesi;
        private System.Windows.Forms.ColumnHeader azalis_yuzdesi;
        private System.Windows.Forms.ColumnHeader fiyat_max;
        private System.Windows.Forms.ColumnHeader fiyat_min;
        private System.Windows.Forms.ColumnHeader urun_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label min_fiyat_txt;
        private System.Windows.Forms.TextBox max_fiyat_txt;
        private System.Windows.Forms.TextBox urun_fiyat_min;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ktg_id_txt;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_cikis;
    }
}