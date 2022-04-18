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
    public partial class AdminEkran : MetroFramework.Forms.MetroForm
    {
        public AdminEkran()
        {
            InitializeComponent();           
        }

        private void AdminEkran_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        Sqlbaglanti baglanti =new Sqlbaglanti();

        void CoinGoster()
        {
            SqlCommand komut = new SqlCommand("Execute AdminGoster ", baglanti.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();                    /* AdminGoster procedure ile admin ekranında coin kontrol kisminda 
                                                                datagridview a onay almamis coin eklemelerini yazdiriyor*/
            da.Fill(dt);
            dgvUrunKontrol.DataSource = dt;
        }
        void ParaGoster()
        {
            SqlCommand komut1 = new SqlCommand("Execute AdminParaGoster ", baglanti.baglanti());
            SqlDataAdapter da1 = new SqlDataAdapter(komut1);
            DataTable dt1= new DataTable();                    /*AdminParaGoster Procedure ile onay almamis para atimlari 
                                                                * datagridview e yazdiriliyor*/
            da1.Fill(dt1);
            dgvParaKontrol.DataSource = dt1;
        }

        private void btnCoinEkle_Click(object sender, EventArgs e)
        {
            string userID;
            int ItemID;
            userID=dgvUrunKontrol.CurrentRow.Cells["UserID"].Value.ToString(); //sisteme coin yukleyen kullanicinin id sini tutuyor.
            ItemID = Convert.ToInt32(dgvUrunKontrol.CurrentRow.Cells["ItemID"].Value);//hangi coin i yukledigini tutuyor.
            SqlCommand komut = new SqlCommand("Execute Onay " +"'"+userID+"'"+","+ItemID , baglanti.baglanti());
            komut.ExecuteNonQuery();      //Admin onay kismi.
            CoinGoster();
            baglanti.baglanti().Close();
        }

        private void btnParaEkle_Click(object sender, EventArgs e)
        {
            string userId;
            userId = dgvParaKontrol.CurrentRow.Cells["UserID1"].Value.ToString();//Para ekleyen kullanicinin id sini tutuyor.

            SqlCommand komut = new SqlCommand("Execute ParaOnay " + "'"+userId+"'", baglanti.baglanti());
            komut.ExecuteNonQuery();         //Admin onay kismi
            ParaGoster();
            baglanti.baglanti().Close();
            
        }

        private void mtabPara_Enter(object sender, EventArgs e)
        {
            ParaGoster();
        }

        private void mtabPageUrun_Enter(object sender, EventArgs e)
        {
            CoinGoster();
        }
    }
}
