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
    public partial class Yonetici_Yetkili_Islemleri : Form
    {

        cGenel gnl = new cGenel();

        public Yonetici_Yetkili_Islemleri()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttn_yetkili_ekle_Click(object sender, EventArgs e)
        {
            if(yetkili_ad_txt.Text.Trim() != "" & yetkili_soyad_txt.Text.Trim() != "" & sifre_txt.Text.Trim() != "" & sifre_tekrar_txt.Text.Trim() != "" &txt_telefon_no.Text.Trim() != "" & kullanici_adi_txt.Text.Trim() != "" & yetkili_grv_id.Text.Trim() != "" )
            {
                if((sifre_txt.Text.Trim()==sifre_tekrar_txt.Text.Trim())) // parola kac karakterden olusmali?
                {
                    yetkililer ytk = new yetkililer();
                    ytk.Yetkili_ad = yetkili_ad_txt.Text.Trim();
                    ytk.Yetkili_soyad = yetkili_soyad_txt.Text.Trim();
                    ytk.Parola = sifre_txt.Text.Trim();
                    ytk.Kullanici_adi = kullanici_adi_txt.Text.Trim();
                    ytk.Yetkili_telefon = txt_telefon_no.Text.Trim();
                    ytk.Yetkili_tip_id = Convert.ToInt32(yetkili_grv_id.Text);
                    bool sonuc = ytk.yetkili_ekle(ytk);

                    if(sonuc)
                    {
                        MessageBox.Show("Kayıt Başarıyla Eklenmiştir.");
                        ytk.yetkili_bilgi_getir_lv(lv_yetkililer);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Eklenemedi. ");
                    }

                }

                else
                {
                    MessageBox.Show("Şifreler Aynı Değil!! Kontrol Ediniz. ");

                }

            }

            else
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız.");
            }

        }



        private void cmb_gorev_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gorevler grv = (Gorevler)cmb_gorev.SelectedItem;
            yetkili_grv_id.Text = Convert.ToString(grv.Yetkili_tip_id);

        }

        private void Yonetici_Yetkili_Islemleri_Load(object sender, EventArgs e)
        {
            cGenel gnl = new cGenel();
            yetkililer ytk = new yetkililer();
            Gorevler grv = new Gorevler();
            grv.yetkiliGorevGetir(cmb_gorev);
            lv_yetkililer.View = View.Details;
            lv_yetkililer.GridLines = true;
            ytk.yetkili_bilgi_getir_lv(lv_yetkililer);
        }

        private void lv_yetkililer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lv_yetkililer.SelectedItems.Count>0)
            {
                yetkili_ad_txt.Text = lv_yetkililer.SelectedItems[0].SubItems[1].Text;
                yetkili_soyad_txt.Text = lv_yetkililer.SelectedItems[0].SubItems[2].Text;
                yetkili_grv_id.Text = lv_yetkililer.SelectedItems[0].SubItems[4].Text;
                kullanici_adi_txt.Text = lv_yetkililer.SelectedItems[0].SubItems[5].Text;
                txt_telefon_no.Text = lv_yetkililer.SelectedItems[0].SubItems[6].Text;
                
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
            if(MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?","UYARI!",MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes);
            {
                Application.Exit();
            }

        }

        private void btn_yetkili_sil_Click(object sender, EventArgs e)
        {
            if(lv_yetkililer.SelectedItems.Count>0)
            {
                if (MessageBox.Show("Silme işlemi yapmak istediğinizden emin misiniz", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    yetkililer ytk = new yetkililer();
                    bool sonuc = ytk.yetkili_sil(Convert.ToInt32(lv_yetkililer.SelectedItems[0].Text));
                    if(sonuc)
                    {
                        MessageBox.Show("Kayıt başarıyla silinmiştir.");
                        ytk.yetkili_bilgi_getir_lv(lv_yetkililer);
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

        private void btn_yetkili_guncelle_Click(object sender, EventArgs e)
        {
            if(lv_yetkililer.SelectedItems.Count>0)
            {
                if(yetkili_ad_txt.Text.Trim() != "" & yetkili_soyad_txt.Text.Trim() != "" & sifre_txt.Text.Trim() != "" & sifre_tekrar_txt.Text.Trim() != "" & txt_telefon_no.Text.Trim() != "" & kullanici_adi_txt.Text.Trim() != "" & yetkili_grv_id.Text.Trim() != "")
                {
                    if(sifre_tekrar_txt.Text.Trim()==sifre_txt.Text.Trim())
                    {
                        yetkililer ytk = new yetkililer();
                        ytk.Yetkili_ad = yetkili_ad_txt.Text;
                        ytk.Yetkili_soyad = yetkili_soyad_txt.Text;
                        ytk.Parola = sifre_txt.Text;
                        ytk.Yetkili_telefon = txt_telefon_no.Text;
                        ytk.Kullanici_adi = kullanici_adi_txt.Text;
                        ytk.Yetkili_tip_id = Convert.ToInt32(yetkili_grv_id.Text);
                        bool sonuc = ytk.yetkili_guncelle(ytk, Convert.ToInt32(yetkili_grv_id.Text));

                        if(sonuc)
                        {
                            MessageBox.Show("Kayıt Başarıyla Güncellenmiştir..");
                            ytk.yetkili_bilgi_getir_lv(lv_yetkililer);
                        }
                        else
                        {
                            MessageBox.Show("Kayıt Eklenemedi. Tekrar Kontrol Ediniz..");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Şifreler Aynı Değil!!");
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
    }
}
