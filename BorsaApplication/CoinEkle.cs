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
    public partial class CoinEkle : MetroFramework.Forms.MetroForm
    {
        string kullaniciAdi;
        public CoinEkle(string userid)
        {
            kullaniciAdi = userid;
            InitializeComponent();
        }

        Sqlbaglanti baglanti = new Sqlbaglanti();
        int itemid;
        string itemName;
        private void btnCoinEkle_Click(object sender, EventArgs e)
        {
            SqlCommand sqlkomut = new SqlCommand("Select * From Tbl_Items Where ItemName=@p1", baglanti.baglanti());
            sqlkomut.Parameters.AddWithValue("@p1", cmbCoin.SelectedItem);      //Combobox taki secilen item aktariliyor.
            SqlDataReader dataReader = sqlkomut.ExecuteReader();

            if (dataReader.Read())
            {
                itemid = Convert.ToInt32(dataReader["ItemID"]);
                itemName = dataReader["ItemName"].ToString();
            }
            SqlCommand komut = new SqlCommand("Execute ItemEkleme "+"'"+kullaniciAdi+"'"+","+itemid+","+"'"+itemName+"'"+","+txtCoinMiktar.Text+","+txtFiyat.Text, baglanti.baglanti());
            komut.ExecuteNonQuery();                         //ItemEkleme procedure ile admine gonderilmek uzere sisteme coin ekleniyor.
            MessageBox.Show("Onay için bekleniyor");
            baglanti.baglanti().Close();
            this.Close();
            
        }


        private void CoinEkle_Load(object sender, EventArgs e)
        {
            SqlCommand doldur = new SqlCommand("SELECT ItemName FROM Tbl_Items", baglanti.baglanti());
            SqlDataReader dr = doldur.ExecuteReader();
            while (dr.Read())
            {

                cmbCoin.Items.Add(dr[0]);   //combobox a Tbl_ıtems daki coin isimleri aktariliyor.
            }


            baglanti.baglanti().Close();
        }
    }
}
