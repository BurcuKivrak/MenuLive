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
    public partial class Yetkili_AnaEkran : Form
    {
        public Yetkili_AnaEkran()
        {
            InitializeComponent();
        }

        

        private void kategorii_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Yonetici_Kategori_Islemleri frm = new Yonetici_Kategori_Islemleri();
            frm.Show();
        }

        private void urun_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Yonetici_Urun_Islemleri frm = new Yonetici_Urun_Islemleri();
            frm.Show();
        }

        private void yonetici_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Yonetici_Yetkili_Islemleri frm = new Yonetici_Yetkili_Islemleri();
            frm.Show();
        }


    }
}
