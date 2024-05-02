
namespace MenuLive
{
    partial class Yetkili_AnaEkran
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
            this.urun_btn = new System.Windows.Forms.Button();
            this.yonetici_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kategorii_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // urun_btn
            // 
            this.urun_btn.Location = new System.Drawing.Point(240, 97);
            this.urun_btn.Name = "urun_btn";
            this.urun_btn.Size = new System.Drawing.Size(105, 96);
            this.urun_btn.TabIndex = 0;
            this.urun_btn.Text = "Ürün İşlemleri";
            this.urun_btn.UseVisualStyleBackColor = true;
            this.urun_btn.Click += new System.EventHandler(this.urun_btn_Click);
            // 
            // yonetici_btn
            // 
            this.yonetici_btn.Location = new System.Drawing.Point(378, 97);
            this.yonetici_btn.Name = "yonetici_btn";
            this.yonetici_btn.Size = new System.Drawing.Size(108, 96);
            this.yonetici_btn.TabIndex = 0;
            this.yonetici_btn.Text = "Yetkili İşlemleri";
            this.yonetici_btn.UseVisualStyleBackColor = true;
            this.yonetici_btn.Click += new System.EventHandler(this.yonetici_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(145, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yönetici Hoşgeldiniz";
            // 
            // kategorii_btn
            // 
            this.kategorii_btn.Location = new System.Drawing.Point(110, 97);
            this.kategorii_btn.Name = "kategorii_btn";
            this.kategorii_btn.Size = new System.Drawing.Size(105, 96);
            this.kategorii_btn.TabIndex = 0;
            this.kategorii_btn.Text = "Kategori İşlemleri";
            this.kategorii_btn.UseVisualStyleBackColor = true;
            this.kategorii_btn.Click += new System.EventHandler(this.kategorii_btn_Click);
            // 
            // Yetkili_AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 354);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yonetici_btn);
            this.Controls.Add(this.kategorii_btn);
            this.Controls.Add(this.urun_btn);
            this.Name = "Yetkili_AnaEkran";
            this.Text = "Yetkili_AnaEkran";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button urun_btn;
        private System.Windows.Forms.Button yonetici_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kategorii_btn;
    }
}