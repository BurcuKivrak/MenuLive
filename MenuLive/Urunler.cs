using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text;
using System.Drawing;
using System.Data;


namespace MenuLive
{
    class Urunler
    {

        cGenel gnl = new cGenel();


        private int urun_id;
        private string urun_adi;
        private int kategori_id;
        private double urun_fiyat_guncel;
        private string urun_aciklama;
        private int urun_artis;
        private int urun_azalis;
        private int urun_max;
        private int urun_min;
        private int urun_satis_miktari;
        private string urun_gorsel;


        public int Urun_id { get => urun_id; set => urun_id = value; }
        public string Urun_adi { get => urun_adi; set => urun_adi = value; }
        public int Kategori_id { get => kategori_id; set => kategori_id = value; }
        public double Urun_fiyat_guncel { get => urun_fiyat_guncel; set => urun_fiyat_guncel = value; }
        public string Urun_aciklama { get => urun_aciklama; set => urun_aciklama = value; }
        public int Urun_artis { get => urun_artis; set => urun_artis = value; }
        public int Urun_azalis { get => urun_azalis; set => urun_azalis = value; }
        public int Urun_max { get => urun_max; set => urun_max = value; }
        public int Urun_min { get => urun_min; set => urun_min = value; }
        public int Urun_satis_miktari { get => urun_satis_miktari; set => urun_satis_miktari = value; }

        public string Urun_gorsel { get => urun_gorsel; set => urun_gorsel = value; }

        public bool urun_ekleme(Urunler urun)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("insert into Urunler(kategori_id, urun_ad, urun_fiyat_guncel, urun_gorsel, urun_aciklama, u_artis_yuzde, u_azalis_yuzde, urun_fiyat_max, urun_fiyat_min) values (@p0, @p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)",con);

            cmd.Parameters.Add("p0", SqlDbType.Int).Value = urun.Kategori_id;
            cmd.Parameters.Add("p1", SqlDbType.NVarChar).Value = urun.Urun_adi;
            cmd.Parameters.Add("p2", SqlDbType.Int).Value = urun.Urun_fiyat_guncel;
            cmd.Parameters.Add("p3", SqlDbType.VarChar).Value = urun.Urun_gorsel;
            cmd.Parameters.Add("p4", SqlDbType.NVarChar).Value = urun.Urun_aciklama;
            cmd.Parameters.Add("p5", SqlDbType.SmallInt).Value = urun.Urun_artis;
            cmd.Parameters.Add("p6", SqlDbType.SmallInt).Value = urun.Urun_azalis;
            cmd.Parameters.Add("p7", SqlDbType.SmallInt).Value = urun.Urun_max;
            cmd.Parameters.Add("p8", SqlDbType.SmallInt).Value = urun.Urun_min;

            try
            {
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                }

                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
                throw;
            }

            con.Close();
            return sonuc;
        }

        public bool urun_silme(int ur_id)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Delete from Urunler where u_id=@p1", con);

            cmd.Parameters.Add("@p1", SqlDbType.Int).Value = ur_id;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }

            catch (Exception ex)
            {
                string hata = ex.Message;

                throw;
            }

            con.Close();
            return sonuc;

        }


        public void UrunGetir_lv(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select u_id, kategori_id, urun_ad, urun_fiyat_guncel, urun_aciklama, u_artis_yuzde, u_azalis_yuzde, urun_fiyat_max, urun_fiyat_min from Urunler", con);
            
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }

            SqlDataReader oku = cmd.ExecuteReader();
            int sayac = 0;
            while(oku.Read())
            {
                lv.Items.Add(oku["u_id"].ToString());
                lv.Items[sayac].SubItems.Add(oku["kategori_id"].ToString());
                lv.Items[sayac].SubItems.Add(oku["urun_ad"].ToString());
                lv.Items[sayac].SubItems.Add(oku["urun_fiyat_guncel"].ToString());
                lv.Items[sayac].SubItems.Add(oku["urun_aciklama"].ToString());
                lv.Items[sayac].SubItems.Add(oku["u_artis_yuzde"].ToString());
                lv.Items[sayac].SubItems.Add(oku["u_azalis_yuzde"].ToString());
                lv.Items[sayac].SubItems.Add(oku["urun_fiyat_max"].ToString());
                lv.Items[sayac].SubItems.Add(oku["urun_fiyat_min"].ToString());
                sayac++;
            }
            oku.Close();
            con.Close();
        }


        public bool urun_Guncelle(Urunler urn, int ur_id)
        {
            bool sonuc = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("update Urunler set urun_ad=@p1, kategori_id=@p2, urun_fiyat_guncel=@p3, urun_gorsel=@p4, urun_aciklama=@p5, u_artis_yuzde=@p6, u_azalis_yuzde=@p7, urun_fiyat_max=@p8, urun_fiyat_min=@p9 where u_id=ur_id", con);

            cmd.Parameters.Add("u_id", SqlDbType.Int).Value = ur_id;
            cmd.Parameters.Add("p1", SqlDbType.NVarChar).Value = urn.Urun_adi;
            cmd.Parameters.Add("p2", SqlDbType.SmallInt).Value =urn.Kategori_id;
            cmd.Parameters.Add("p3", SqlDbType.Int).Value = urn.Urun_fiyat_guncel;
            cmd.Parameters.Add("p4", SqlDbType.Int).Value = urn. Urun_gorsel;
            cmd.Parameters.Add("p5", SqlDbType.NVarChar).Value = urn.Urun_aciklama;
            cmd.Parameters.Add("p6", SqlDbType.Int).Value = urn.Urun_artis;
            cmd.Parameters.Add("p7", SqlDbType.Int).Value = urn.Urun_azalis;
            cmd.Parameters.Add("p8", SqlDbType.Int).Value = urn.Urun_max;
            cmd.Parameters.Add("p9", SqlDbType.Int).Value = urn.Urun_min;


            try
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());


            }
            catch (Exception ex)
            {
                string hata = ex.Message;
                throw;
            }

            con.Close();
            return sonuc;

        }

    }
}
