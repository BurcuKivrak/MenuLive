
namespace MenuLive
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
            this.KullaniciAdi_txt = new System.Windows.Forms.TextBox();
            this.Giris_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Sifre_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KullaniciAdi_txt
            // 
            this.KullaniciAdi_txt.Location = new System.Drawing.Point(156, 67);
            this.KullaniciAdi_txt.Name = "KullaniciAdi_txt";
            this.KullaniciAdi_txt.Size = new System.Drawing.Size(100, 22);
            this.KullaniciAdi_txt.TabIndex = 0;
            // 
            // Giris_btn
            // 
            this.Giris_btn.Location = new System.Drawing.Point(113, 163);
            this.Giris_btn.Name = "Giris_btn";
            this.Giris_btn.Size = new System.Drawing.Size(75, 23);
            this.Giris_btn.TabIndex = 1;
            this.Giris_btn.Text = "Giriş Yap";
            this.Giris_btn.UseVisualStyleBackColor = true;
            this.Giris_btn.Click += new System.EventHandler(this.Giris_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanici Adi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hoşgeldiniz";
            // 
            // Sifre_txt
            // 
            this.Sifre_txt.Location = new System.Drawing.Point(156, 105);
            this.Sifre_txt.Name = "Sifre_txt";
            this.Sifre_txt.Size = new System.Drawing.Size(100, 22);
            this.Sifre_txt.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 306);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Giris_btn);
            this.Controls.Add(this.Sifre_txt);
            this.Controls.Add(this.KullaniciAdi_txt);
            this.Name = "Form1";
            this.Text = "Giris Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox KullaniciAdi_txt;
        private System.Windows.Forms.Button Giris_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Sifre_txt;
        private System.Windows.Forms.Label label3;
    }
}

