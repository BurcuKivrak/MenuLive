
namespace MenuLive
{
    partial class Yonetici_Kategori_Islemleri
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
            this.back_btn = new System.Windows.Forms.Button();
            this.Kategori_ekle = new System.Windows.Forms.Button();
            this.ad_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aciklama_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.list_kategoriler = new System.Windows.Forms.ListView();
            this.Kategori_id_index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kategori_adi_index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kategori_aciklama_index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.lbl_yetkili = new System.Windows.Forms.Label();
            this.Yetkili_gorev = new System.Windows.Forms.Label();
            this.txt_kategori_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(17, 225);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(72, 60);
            this.back_btn.TabIndex = 0;
            this.back_btn.Text = "Geri dön";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // Kategori_ekle
            // 
            this.Kategori_ekle.Location = new System.Drawing.Point(28, 143);
            this.Kategori_ekle.Name = "Kategori_ekle";
            this.Kategori_ekle.Size = new System.Drawing.Size(100, 23);
            this.Kategori_ekle.TabIndex = 1;
            this.Kategori_ekle.Text = "Ekle";
            this.Kategori_ekle.UseVisualStyleBackColor = true;
            this.Kategori_ekle.Click += new System.EventHandler(this.Kategori_ekle_Click);
            // 
            // ad_txt
            // 
            this.ad_txt.Location = new System.Drawing.Point(145, 56);
            this.ad_txt.Name = "ad_txt";
            this.ad_txt.Size = new System.Drawing.Size(141, 22);
            this.ad_txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kategori Adı:";
            // 
            // aciklama_txt
            // 
            this.aciklama_txt.Location = new System.Drawing.Point(145, 97);
            this.aciklama_txt.Name = "aciklama_txt";
            this.aciklama_txt.Size = new System.Drawing.Size(141, 22);
            this.aciklama_txt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori Açıklama:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kategeri İşlemleri";
            // 
            // list_kategoriler
            // 
            this.list_kategoriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Kategori_id_index,
            this.kategori_adi_index,
            this.kategori_aciklama_index});
            this.list_kategoriler.HideSelection = false;
            this.list_kategoriler.Location = new System.Drawing.Point(357, 59);
            this.list_kategoriler.Name = "list_kategoriler";
            this.list_kategoriler.Size = new System.Drawing.Size(317, 173);
            this.list_kategoriler.TabIndex = 4;
            this.list_kategoriler.UseCompatibleStateImageBehavior = false;
            this.list_kategoriler.View = System.Windows.Forms.View.Details;
            this.list_kategoriler.SelectedIndexChanged += new System.EventHandler(this.list_kategori_selectedIndex);
            // 
            // Kategori_id_index
            // 
            this.Kategori_id_index.Text = "Kategori ID";
            this.Kategori_id_index.Width = 83;
            // 
            // kategori_adi_index
            // 
            this.kategori_adi_index.Text = "Kategori Adı";
            this.kategori_adi_index.Width = 102;
            // 
            // kategori_aciklama_index
            // 
            this.kategori_aciklama_index.Text = "Kategori Açıklama";
            this.kategori_aciklama_index.Width = 126;
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(144, 143);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(71, 23);
            this.btn_sil.TabIndex = 5;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(221, 143);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(82, 23);
            this.btn_guncelle.TabIndex = 5;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // lbl_yetkili
            // 
            this.lbl_yetkili.AutoSize = true;
            this.lbl_yetkili.Location = new System.Drawing.Point(454, 301);
            this.lbl_yetkili.Name = "lbl_yetkili";
            this.lbl_yetkili.Size = new System.Drawing.Size(0, 17);
            this.lbl_yetkili.TabIndex = 6;
            // 
            // Yetkili_gorev
            // 
            this.Yetkili_gorev.AutoSize = true;
            this.Yetkili_gorev.Location = new System.Drawing.Point(552, 301);
            this.Yetkili_gorev.Name = "Yetkili_gorev";
            this.Yetkili_gorev.Size = new System.Drawing.Size(0, 17);
            this.Yetkili_gorev.TabIndex = 6;
            // 
            // txt_kategori_id
            // 
            this.txt_kategori_id.Location = new System.Drawing.Point(292, 59);
            this.txt_kategori_id.Name = "txt_kategori_id";
            this.txt_kategori_id.Size = new System.Drawing.Size(15, 22);
            this.txt_kategori_id.TabIndex = 7;
            // 
            // Yonetici_Kategori_Islemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 380);
            this.Controls.Add(this.txt_kategori_id);
            this.Controls.Add(this.Yetkili_gorev);
            this.Controls.Add(this.lbl_yetkili);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.list_kategoriler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aciklama_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ad_txt);
            this.Controls.Add(this.Kategori_ekle);
            this.Controls.Add(this.back_btn);
            this.Name = "Yonetici_Kategori_Islemleri";
            this.Text = "Yonetici_Kategori_Islemleri";
            this.Load += new System.EventHandler(this.Yonetici_Kategori_Islemleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button Kategori_ekle;
        private System.Windows.Forms.TextBox ad_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aciklama_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView list_kategoriler;
        private System.Windows.Forms.ColumnHeader Kategori_id_index;
        private System.Windows.Forms.ColumnHeader kategori_adi_index;
        private System.Windows.Forms.ColumnHeader kategori_aciklama_index;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Label lbl_yetkili;
        private System.Windows.Forms.Label Yetkili_gorev;
        private System.Windows.Forms.TextBox txt_kategori_id;
    }
}