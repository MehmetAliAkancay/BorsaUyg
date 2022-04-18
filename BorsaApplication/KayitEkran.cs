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
    public partial class KayitEkran : MetroFramework.Forms.MetroForm
    {
        
        public KayitEkran()
        {
            
            InitializeComponent();
        }

        Sqlbaglanti sqlbaglanti = new Sqlbaglanti();

        bool durum;

        void kontrol()
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Users Where ((UserTcNumber=@p1) or (TelNumber=@p2) or (Email=@p3) or (UserID=@p4))", sqlbaglanti.baglanti());
            komut.Parameters.AddWithValue("@p1", mtxTc.Text);
            komut.Parameters.AddWithValue("@p2", mtxTel.Text);                     /* Kayıt olurken kullanıcı Adı,telefon numarası,Tcsi ve e-maili var olan
                                                                                    * bir kullanıcı ile aynı girilip girilmediğini kontrol ediyor.*/
            komut.Parameters.AddWithValue("@p3", txtMail.Text);
            komut.Parameters.AddWithValue("@p4", txtKullaniciAd.Text);

            SqlDataReader read = komut.ExecuteReader();

            if (read.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            sqlbaglanti.baglanti().Close();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            kontrol();

            if ((durum == true) && (txtAd.Text != "" && txtSoyad.Text != "" && mtxTc.Text != "" && mtxTel.Text != "" &&
                txtAdres.Text != "" && txtMail.Text != "" && txtKullaniciAd.Text != "" && txtSifre.Text != ""))
            {
                SqlCommand sqlkomut = new SqlCommand("insert into Tbl_Users (UserID,UserName,UserSurname,UserTcNumber,TelNumber,Address,Email,Password) values (@p0,@p1,@p2,@p3,@p4,@p5,@p6,@p8)", sqlbaglanti.baglanti());
                sqlkomut.Parameters.AddWithValue("@p0", txtKullaniciAd.Text);
                sqlkomut.Parameters.AddWithValue("@p1", txtAd.Text);
                sqlkomut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                sqlkomut.Parameters.AddWithValue("@p3", mtxTc.Text);               /*Parametlerleri textboxlara atıyoruz.*/
                sqlkomut.Parameters.AddWithValue("@p4", mtxTel.Text);
                sqlkomut.Parameters.AddWithValue("@p5", txtAdres.Text);
                sqlkomut.Parameters.AddWithValue("@p6", txtMail.Text);
                sqlkomut.Parameters.AddWithValue("@p8", txtSifre.Text);
                sqlkomut.ExecuteNonQuery();
                sqlbaglanti.baglanti().Close(); 

                MessageBox.Show("Kayıt işleminiz başarılı bir şekilde gerçekleşti.");
                SqlCommand komut1 = new SqlCommand(" Insert into Tbl_UserTypes(UserTypeID,UserTypeName,UserID) values(" + 2 + "," + "'Kullanıcı'" + "," +"'"+txtKullaniciAd.Text.ToString()+"'" + ")", sqlbaglanti.baglanti());
                komut1.ExecuteNonQuery();
                this.Close();
            }

            else if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text) || string.IsNullOrEmpty(mtxTc.Text) ||
                    string.IsNullOrEmpty(mtxTel.Text) || string.IsNullOrEmpty(txtAdres.Text) || string.IsNullOrEmpty(txtMail.Text) ||
                    string.IsNullOrEmpty(txtKullaniciAd.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {                                                                                      /*Textboxların boş olup olmadığı kontrolü yapılıyor. */
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz.");                                /* Eğer boş ise Ekrana mesaj yazdırılıyor.*/
            }


            else
            {
                MessageBox.Show("Bu sisteme kayıtlı TcKimlikNo,Telefon,E-mail veya Kullanıcı Adı mevcut.");
            }
        }
    }
}
