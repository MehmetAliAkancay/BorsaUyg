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

namespace BorsaApplication
{
    public partial class GirisEkran : MetroFramework.Forms.MetroForm
    {
        public GirisEkran()
        {
            InitializeComponent();
        }

        Sqlbaglanti sqlbaglanti = new Sqlbaglanti();

        string userid;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Users Where UserID=@p1 and Password=@p2", sqlbaglanti.baglanti());

            komut.Parameters.AddWithValue("@p1", mtxtGirisKullanici.Text); //kullanici ve sifreyi parametrelerde tutuyor.
            komut.Parameters.AddWithValue("@p2", mtxtGirisSifre.Text);
            

            SqlDataReader dataReader = komut.ExecuteReader();
            
            if (dataReader.Read())
            {
                userid = dataReader["UserID"].ToString(); 
                
            }
            
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız Lütfen Tekrar Deneyin");
            }
            dataReader.Close();
            komut.CommandText = "Select UserTypeID from Tbl_UserTypes Where UserID='" +userid+"'";
            SqlDataReader dr = komut.ExecuteReader();
            dr.Read();
            if(dr.HasRows)
            {
                if (dr["UserTypeID"].ToString() == "1")
                {
                    AdminEkran admin = new AdminEkran(); //Admin girisi
                    admin.Show();
                    this.Hide();
                }
                else if (dr["UserTypeID"].ToString() == "2")
                {
                    AnaEkran anaEkran = new AnaEkran(userid); //kullanici girisi
                    anaEkran.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş Yaptınız");
                }
            }
            


            sqlbaglanti.baglanti().Close();

        }

        private void btnGirisKayit_Click(object sender, EventArgs e)
        {
            KayitEkran kayit = new KayitEkran();
            kayit.Show();
        }
    }
}
