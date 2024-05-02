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
    public partial class Form1 : Form
    {

        cGenel gnl = new cGenel();
        public Form1()
        {
            InitializeComponent();
        }

   

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        

        private void Giris_btn_Click(object sender, EventArgs e)
        {
            cGenel gnl = new cGenel();
            yetkililer ytk = new yetkililer();
            bool sonuc = ytk.yetkili_kontrol(Sifre_txt.Text, KullaniciAdi_txt.Text);
            if(sonuc)
            {
                string gorev = ytk.yetkili_id_getir(ytk.Yetkili_id);
                if(gorev=="5")
                {
                    this.Hide();
                    Yetkili_AnaEkran frm = new Yetkili_AnaEkran();
                    frm.Show();
                }
                else
                {
                    this.Hide();
                    Personel_AnaEkran frm = new Personel_AnaEkran();
                    frm.Show();
                }
                
            }
            else
            {
                MessageBox.Show("Bir şeyler yanlış!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
    }
}
