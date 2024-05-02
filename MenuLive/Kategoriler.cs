using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace MenuLive
{
    class Kategoriler
    {
        cGenel gnl = new cGenel();

        private int kategori_id;
        private string kategori_adi;
        private string aciklama;

        public int Kategori_id { get => kategori_id; set => kategori_id = value; }
        public string Kategori_adi { get => kategori_adi; set => kategori_adi = value; }
        public string Aciklama { get => aciklama; set => aciklama = value; }

        public bool kategori_ekle(Kategoriler ktg)
        {

            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into Kategoriler(kategori_adi,kategori_aciklama)values(@p1,@p2)",con);
            cmd.Parameters.Add("@p1", SqlDbType.VarChar).Value = ktg.Kategori_adi;
            cmd.Parameters.Add("@p2", SqlDbType.VarChar).Value = ktg.aciklama;

            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                string hata = ex.Message;

                
            }

            con.Close();
            return sonuc;
        }

        public void kategori_getir(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from Kategoriler", con);

            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }

            SqlDataReader oku = cmd.ExecuteReader();

            int sayac = 0;
            while(oku.Read())
            {
                lv.Items.Add(oku["kategori_id"].ToString());
                lv.Items[sayac].SubItems.Add(oku["kategori_adi"].ToString());
                lv.Items[sayac].SubItems.Add(oku["kategori_aciklama"].ToString());

                sayac++;

            }
            oku.Close();
            con.Close();

        }

        public bool kategori_sil(int kategori_idd)
        {

            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Delete from Kategoriler where kategori_id=@p1", con);

            cmd.Parameters.Add("@p1", SqlDbType.Int).Value = kategori_idd;

            try
            {
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }

            catch(Exception ex)
            {
                string hata = ex.Message;

                throw;
            }

            con.Close();
            return sonuc;

        }

        public bool kategori_guncelle(Kategoriler kg,int kat_id)
        {
            bool sonuc = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("update Kategoriler set kategori_adi=@p1, kategori_aciklama=@p2 where kategori_id=@p3", con);

            cmd.Parameters.Add("@p3", SqlDbType.Int).Value = kat_id;
            cmd.Parameters.Add("@p1", SqlDbType.VarChar).Value = kg.Kategori_adi;
            cmd.Parameters.Add("@p2", SqlDbType.VarChar).Value = kg.Aciklama;

            try
            {
                if(con.State==ConnectionState.Closed)
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

        /*public bool kategori_var_mi(string ad)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from Kategoriler kategori_adi ", con);

        }*/

        public void kategori_cmb_getir(ComboBox cmb)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select kategori_id, kategori_adi from Kategoriler", con);
            SqlDataReader oku = null;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    Kategoriler ktg = new Kategoriler();
                    ktg.Kategori_id= Convert.ToInt32( oku["kategori_id"].ToString());
                    ktg.Kategori_adi =oku["kategori_adi"].ToString();

                    cmb.Items.Add(ktg);
                    

                }
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
                throw;
            }
            oku.Close();
            con.Close();

        }

    }
}
