using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MenuLive
{
    public partial class Yonetici_Kategori_Islemleri : Form
    {

        cGenel gnl = new cGenel();

        public Yonetici_Kategori_Islemleri()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Yetkili_AnaEkran frm = new Yetkili_AnaEkran();
            frm.Show();
        }

        private void Kategori_ekle_Click(object sender, EventArgs e)
        {

            if (ad_txt.Text.Trim() == "" || aciklama_txt.Text.Trim() == "")
            {
                MessageBox.Show("Kategori adı ve açıklama boş bırakılamaz.");
            }
            else
            {
                Kategoriler kg = new Kategoriler();

                kg.Kategori_adi = ad_txt.Text;
                kg.Aciklama = aciklama_txt.Text;
                bool sonuc = kg.kategori_ekle(kg);

                if (sonuc)
                {
                    MessageBox.Show("Kategori Eklenmiştir.");
                    kg.kategori_getir(list_kategoriler);
                }
                else
                {
                    MessageBox.Show("Kaydedilemedi. Kontrol ediniz. ");
                }

            }
        }
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if(list_kategoriler.SelectedItems.Count>0)
            {
                Kategoriler kg = new Kategoriler();
                kg.Kategori_adi=ad_txt.Text;
                kg.Aciklama=aciklama_txt.Text;
                bool sonuc = kg.kategori_guncelle(kg, Convert.ToInt32(txt_kategori_id.Text));

                if(sonuc)
                {
                    MessageBox.Show("Kayıt Başarıyla Güncellenmiştir.");
                    kg.kategori_getir(list_kategoriler);
                }
                else
                {
                    MessageBox.Show("Kayıt güncellenemedi.Kontrol ediniz.");
                }

            }
            else
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz.");
            }
        }

        private void Yonetici_Kategori_Islemleri_Load(object sender, EventArgs e)
        {
            cGenel gnl = new cGenel();
            Kategoriler kg = new Kategoriler();
            yetkililer ytk = new yetkililer();
            list_kategoriler.View = View.Details;
            list_kategoriler.GridLines = true;
            kg.kategori_getir(list_kategoriler);

            lbl_yetkili.Text = "Hoşgeldiniz " + ytk.Kullanici_adi;

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {

            if(list_kategoriler.SelectedItems.Count>0)
            {

                if (MessageBox.Show("Silme İşlemi Yapmak İstediğinizden Emin Misiniz?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Kategoriler kg = new Kategoriler();

                    bool sonuc = kg.kategori_sil(Convert.ToInt32(list_kategoriler.SelectedItems[0].Text));
                    if (sonuc)
                    {
                        MessageBox.Show("Kayıt başarıyla silinmiştir..");
                        kg.kategori_getir(list_kategoriler);
                    }
                    else
                    {
                        MessageBox.Show("Bir hata oluştu..");
                    }
                }

            }
            else
            {
                MessageBox.Show("Lutfen Kayit Seçiniz.");
            }

        }

        private void list_kategori_selectedIndex(object sender, EventArgs e)
        {
            if(list_kategoriler.SelectedItems.Count>0)
            {
                btn_guncelle.Enabled = true;
                btn_sil.Enabled = true;
                txt_kategori_id.Text = list_kategoriler.SelectedItems[0].SubItems[0].Text;
                ad_txt.Text = list_kategoriler.SelectedItems[0].SubItems[1].Text;
                aciklama_txt.Text = list_kategoriler.SelectedItems[0].SubItems[2].Text;
            }
            else
            {
                Kategori_ekle.Enabled = true;
            }

        }
    }
}
