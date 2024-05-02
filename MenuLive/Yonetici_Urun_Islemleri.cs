using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuLive
{
    public partial class Yonetici_Urun_Islemleri : Form
    {
        public Yonetici_Urun_Islemleri()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CallEnter_click(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void resim_sec_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Resim Dosyası | *.jpg; *.nef; *.png | Tüm Dosyalar | *.* ";
            openFileDialog1.ShowDialog();
            string dosya_yolu = openFileDialog1.FileName;
            resim_txt.Text = dosya_yolu;
            pictureBox1.ImageLocation = dosya_yolu;
        }

        private void btn_urun_ekle_Click(object sender, EventArgs e)
        {
            if (txt_urun_ad.Text.Trim() != "" & txt_urun_fiyati.Text.Trim() != "" & txt_urun_aciklama.Text.Trim() != "" )
            {
                Urunler urun = new Urunler();
                urun.Urun_adi = txt_urun_ad.Text;
                urun.Urun_gorsel = resim_txt.Text;
                urun.Urun_aciklama = txt_urun_aciklama.Text;
                urun.Urun_fiyat_guncel = Convert.ToDouble(txt_urun_fiyati.Text);
                urun.Kategori_id = Convert.ToInt32(ktg_id_txt.Text);
                urun.Urun_artis = Convert.ToInt32(txt_urun_artis.Text);
                urun.Urun_azalis = Convert.ToInt32(txt_urun_azalis.Text);
                urun.Urun_max = Convert.ToInt32(max_fiyat_txt.Text);
                urun.Urun_min = Convert.ToInt32(urun_fiyat_min.Text);

                bool sonuc = urun.urun_ekleme(urun);
                if(sonuc)
                {
                    MessageBox.Show("Kayıt Başarıyla Eklenmiştir..");
                    urun.UrunGetir_lv(lv_Urunler);
                }
            }
        }

        private void Yonetici_Urun_Islemleri_Load(object sender, EventArgs e)
        {
            Urunler urn = new Urunler();
            Kategoriler ktg = new Kategoriler();
            ktg.kategori_cmb_getir(comboBox1);
            lv_Urunler.View = View.Details;
            lv_Urunler.GridLines = true;
            urn.UrunGetir_lv(lv_Urunler);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kategoriler ktg = (Kategoriler)comboBox1.SelectedItem;
            ktg_id_txt.Text =Convert.ToString (ktg.Kategori_id);

        }

        ////////////////// urun silme button /////////////////
        private void button3_Click(object sender, EventArgs e) 
        {
            if (lv_Urunler.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Silme işlemi yapmak istediğinizden emin misiniz", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Urunler urn = new Urunler();
                    bool sonuc = urn.urun_silme(Convert.ToInt32(lv_Urunler.SelectedItems[0].Text));
                    if (sonuc)
                    {
                        MessageBox.Show("Kayıt başarıyla silinmiştir.");
                        urn.UrunGetir_lv(lv_Urunler);
                    }
                    else
                    {
                        MessageBox.Show("Dikkat!! Kayıt silinirken hata oluştu! Kontrol ediniz..");
                    }
                }
            }

            else
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz.");
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Yetkili_AnaEkran formana = new Yetkili_AnaEkran();
            this.Close();
            formana.Show();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "UYARI!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) ;
            {
                Application.Exit();
            }
        }

        private void urun_guncelle_btn_Click(object sender, EventArgs e)
        {
            if (lv_Urunler.SelectedItems.Count > 0)
            {
                if ( urun_ad.Text.Trim() != "" & txt_urun_aciklama.Text.Trim() != "" & txt_urun_fiyati .Text.Trim() != "" & ktg_id_txt.Text.Trim() != "" & urun_fiyat_min.Text.Trim() != "" & max_fiyat_txt.Text.Trim() != "" & txt_urun_artis.Text.Trim() != "" & txt_urun_azalis.Text.Trim() != "" & resim_txt.Text.Trim() !="" )
                {

                        Urunler urn = new Urunler();
                        urn.Urun_adi = urun_ad.Text.Trim();
                        urn.Urun_fiyat_guncel = Convert.ToDouble( txt_urun_fiyati.Text);
                        urn.Urun_aciklama = txt_urun_aciklama.Text.Trim();
                        urn.Urun_artis = Convert.ToInt32( txt_urun_artis.Text);
                        urn.Urun_azalis = Convert.ToInt32(txt_urun_azalis.Text);
                        urn.Urun_gorsel = resim_txt.Text.Trim();
                        urn.Urun_max = Convert.ToInt32(max_fiyat_txt.Text);
                        urn.Urun_min = Convert.ToInt32(urun_fiyat_min.Text);
                        urn.Kategori_id = Convert.ToInt32(kategori_id.Text);
                        bool sonuc = urn.urun_Guncelle(urn, Convert.ToInt32(urun_id));


                        if (sonuc)
                        {
                            MessageBox.Show("Kayıt Başarıyla Güncellenmiştir..");
                            urn.UrunGetir_lv(lv_Urunler);
                        }
                        else
                        {
                            MessageBox.Show("Kayıt Eklenemedi. Tekrar Kontrol Ediniz..");
                        }


                }
                else
                {
                    MessageBox.Show("Boş Alan Bırakmayınız!!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz!!");
            }
        }

        private void lv_Urunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
