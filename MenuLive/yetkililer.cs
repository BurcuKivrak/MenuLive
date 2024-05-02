using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Windows.Forms;

namespace MenuLive
{
    class yetkililer
    {
        cGenel gnl = new cGenel();

        private int yetkili_id;
        private string yetkili_ad;
        private string yetkili_soyad;
        private string yetkili_telefon;
        private int yetkili_tip_id;
        private string parola;
        private string kullanici_adi;

        public int Yetkili_id { get => yetkili_id; set => yetkili_id = value; }
        public string Yetkili_ad { get => yetkili_ad; set => yetkili_ad = value; }
        public string Yetkili_soyad { get => yetkili_soyad; set => yetkili_soyad = value; }
        public string Yetkili_telefon { get => yetkili_telefon; set => yetkili_telefon = value; }
        public int Yetkili_tip_id { get => yetkili_tip_id; set => yetkili_tip_id = value; }
        public string Parola { get => parola; set => parola = value; }
        public string Kullanici_adi { get => kullanici_adi; set => kullanici_adi = value; }
    
        // login kontrol
        public bool yetkili_kontrol(string parola,string kullanici_adi)
        {
            bool sonuc = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Yetkililer where kullanici_adi=@p1 and parola=@p2", con);
            cmd.Parameters.Add("@p1", SqlDbType.VarChar).Value = kullanici_adi;
            cmd.Parameters.Add("@p2", SqlDbType.VarChar).Value = parola;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }
                sonuc = Convert.ToBoolean(cmd.ExecuteScalar());
            }
            catch (SqlException sExtion)
            {


                string hata = sExtion.Message;
                throw;
            }
            return sonuc;
        }
    
    
        //yetkililer işlemler
        public bool yetkili_ekle(yetkililer ytk)

        {
            bool sonuc = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("insert into Yetkililer (yetkili_ad, yetkili_soyad, yetkili_telefon, yetkili_tip_id, parola, kullanici_adi) values (@p1, @p2, @p3, @p4, @p5, @p6)", con);

            cmd.Parameters.Add("p1", SqlDbType.NVarChar).Value = ytk.Yetkili_ad;
            cmd.Parameters.Add("p2", SqlDbType.NVarChar).Value = ytk.Yetkili_soyad;
            cmd.Parameters.Add("p3", SqlDbType.VarChar).Value = ytk.Yetkili_telefon;
            cmd.Parameters.Add("p4", SqlDbType.SmallInt).Value = ytk.Yetkili_tip_id;
            cmd.Parameters.Add("p5", SqlDbType.VarChar).Value = ytk.Parola;
            cmd.Parameters.Add("p6", SqlDbType.VarChar).Value = ytk.Kullanici_adi;


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

        public bool yetkili_sil(int yetkili_idd)
        {

            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd= new SqlCommand("Delete from Yetkililer where yetkili_id=@p1", con);

            cmd.Parameters.Add("@p1", SqlDbType.Int).Value = yetkili_idd;

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

        public bool yetkili_guncelle(yetkililer ytk, int yet_id)
        {

            bool sonuc = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("update Yetkililer set yetkili_ad=@p1, yetkili_soyad=@p2, yetkili_telefon=@p3, yetkili_tip_id=@p4, parola=@p5 kullanici_adi=@p6 where yetkili_id=@p7", con);

            cmd.Parameters.Add("@p7", SqlDbType.Int).Value = yet_id;
            cmd.Parameters.Add("@p1", SqlDbType.VarChar).Value = ytk.Yetkili_ad;
            cmd.Parameters.Add("@p2", SqlDbType.VarChar).Value = ytk.Yetkili_soyad;
            cmd.Parameters.Add("@p3", SqlDbType.VarChar).Value = ytk.Yetkili_telefon;
            cmd.Parameters.Add("@p4", SqlDbType.VarChar).Value = ytk.Yetkili_tip_id;
            cmd.Parameters.Add("@p5", SqlDbType.VarChar).Value = ytk.Parola;
            cmd.Parameters.Add("@p6", SqlDbType.VarChar).Value = ytk.Kullanici_adi;


            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
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


        public void yetkili_bilgi_getir_lv(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Yetkililer.yetkili_id, Yetkililer.yetkili_ad, Yetkililer.yetkili_soyad, Yetkililer.yetkili_telefon, Yetkililer.yetkili_tip_id, Yetkililer.parola, Yetkililer.kullanici_adi, Gorevler.yetkili_gorev from Yetkililer inner join Gorevler on Yetkililer.yetkili_tip_id = Gorevler.yetkili_tip_id ", con);

            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader oku = cmd.ExecuteReader();

            int sayac = 0;
            while (oku.Read())
            {
                    lv.Items.Add(oku["yetkili_id"].ToString());
                    lv.Items[sayac].SubItems.Add(oku["yetkili_ad"].ToString());
                    lv.Items[sayac].SubItems.Add(oku["yetkili_soyad"].ToString());
                    lv.Items[sayac].SubItems.Add(oku["yetkili_tip_id"].ToString());
                    lv.Items[sayac].SubItems.Add(oku["yetkili_gorev"].ToString());
                    lv.Items[sayac].SubItems.Add(oku["kullanici_adi"].ToString());
                    lv.Items[sayac].SubItems.Add(oku["yetkili_telefon"].ToString());
                    lv.Items[sayac].SubItems.Add(oku["parola"].ToString());



                sayac++;

            }
            oku.Close();
            con.Close();

        }

        public void yetkili_getir_gorev(ComboBox cb)
        {
            cb.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * Yetkililer", con);

            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }

            SqlDataReader oku = cmd.ExecuteReader();

            while(oku.Read())
            {
                yetkililer ytk = new yetkililer();
                ytk.Yetkili_id = Convert.ToInt32(oku["yetkili_id"]);
                ytk.Yetkili_ad = Convert.ToString(oku["yetkili_ad"]);
                ytk.Yetkili_soyad = Convert.ToString(oku["yetkili_soyad"]);
                ytk.Yetkili_telefon = Convert.ToString(oku["yetkili_telefon"]);
                ytk.Yetkili_tip_id = Convert.ToInt32(oku["yetkili_tip_id"]);
                ytk.Parola = Convert.ToString(oku["parola"]);
                ytk.Kullanici_adi = Convert.ToString(oku["kullanici_adi"]);
                cb.Items.Add(cb);
            }

            oku.Close();
            con.Close();


        }

        public string yetkili_id_getir(int yetkili_idd)
        {

            string sonuc = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select yetkili_tip_id from Yetkililer where yetkili_id=@p1", con);

            cmd.Parameters.Add("p1", SqlDbType.Int).Value = yetkili_idd;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }
                sonuc = cmd.ExecuteScalar().ToString();
            }
            catch (SqlException sExtion)
            {
                string hata = sExtion.Message;
                throw;
            }
            con.Close();
            return sonuc;
        }    
    }
}
