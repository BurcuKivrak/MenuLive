using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MenuLive
{
    class Gorevler
    {

        cGenel gnl = new cGenel();

        private int yetkili_id;
        private int yetkili_tip_id;
        private string yetkili_gorev;
        private string aciklama;

        public int Yetkili_id { get => yetkili_id; set => yetkili_id = value; }
        public int Yetkili_tip_id { get => yetkili_tip_id; set => yetkili_tip_id = value; }
        public string Yetkili_gorev { get => yetkili_gorev; set => yetkili_gorev = value; }
        public string Aciklama { get => aciklama; set => aciklama = value; }


        public void yetkiliGorevGetir(ComboBox cb)
        {
            cb.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from Gorevler", con);
            SqlDataReader oku = null;

            try
            {
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                }

                oku = cmd.ExecuteReader();
                while(oku.Read())
                {
                    Gorevler gr = new Gorevler();
                    gr.yetkili_gorev = oku["yetkili_gorev"].ToString();
                    gr.yetkili_tip_id= Convert.ToInt32(oku["yetkili_tip_id"].ToString());
                    
                    cb.Items.Add(gr); 
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


        public string yetkili_gorev_tanim(int yet)
        {
            string sonuc = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select yetkili_gorev from Gorevler where yetkili_id=@yetID", con);
            cmd.Parameters.Add("yetID", SqlDbType.Int).Value = yet;

            try
            {
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                }

                sonuc = cmd.ExecuteScalar().ToString();
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
