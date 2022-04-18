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
    public partial class AnaEkran : MetroFramework.Forms.MetroForm
    {
           
        string kullaniciAdi;
        
        public AnaEkran(string userid)
        {
            
            InitializeComponent();
            kullaniciAdi = userid;
        }
        Sqlbaglanti sqlbaglanti = new Sqlbaglanti();
        

        private void AnaEkran_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {

            this.Show();
           

        }

        public void Goster(string cmdtext,DataGridView dgv)
        {
            SqlCommand komut = new SqlCommand(cmdtext, sqlbaglanti.baglanti()); 
            SqlDataAdapter da = new SqlDataAdapter(komut);                        /* Datagridview e itemları yazdırma*/
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            
            
        }
        public void Ekle(string kmt,DataGridView dgv)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_UserItems", sqlbaglanti.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            dr.Read();                                      /*Sql de item varsa Goster Fonksiyonu ile datagridview e yazdırma*/
            if (dr.HasRows)
            {
                Goster(kmt,dgv);
            }
        }
        double money;
        public void ParaGoster(Label lbl)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Money where UserID=@p1 ", sqlbaglanti.baglanti());
            komut.Parameters.AddWithValue("@p1", kullaniciAdi); //Table dan giris yapan kullaniciniyi bulma
            SqlDataReader dr = komut.ExecuteReader();                 /*Sisteme Giris yapan kullanicinin parasını gösterme*/
            lbl.Text = "0";
            dr.Read();
            if (dr.HasRows)
            {
                if (Convert.ToInt32(dr["MoneyAccept"]) == 1)
                {
                    money = Convert.ToDouble(dr["MoneyAmount"]); //Table da kullanicinin parasını money degiskenine atama
                    lbl.Text = money.ToString();
                }
            }
        }

        public void Satis(int ItemID,TextBox txt,TextBox txt1,DataGridView data)
        {
            SqlCommand komut = new SqlCommand("Execute Satis "+ItemID+","+"'"+kullaniciAdi+"'"+","+txt.Text+","+txt1.Text, sqlbaglanti.baglanti());
            komut.ExecuteNonQuery();                       /*Satıs queryisini calistirip alim islemi gercekletiriyor.*/
            Ekle("Execute ItemGoster " + ItemID, data);    //datagridview i yeniden guncelliyor
            sqlbaglanti.baglanti().Close();
        }

        private void BatteryPage_Enter(object sender, EventArgs e)
        {
            ParaGoster(lblParaBattery);
            Ekle("Execute ItemGoster " + 1, dgvBattery);         /*BatteryCoin sayfasinda kullanicinin parasini ve pazardaki 
                                                                  Battery coinleri gosterme*/
        }

        private void BigPage_Enter(object sender, EventArgs e)
        {
            ParaGoster(lblParaBig);                             
            Ekle("Execute ItemGoster " + 2, dgvBig);              /*BigCoin sayfasinda kullanicinin parasini ve pazardaki 
                                                                   * Big coinleri gosterme*/
        }

        private void PowerPage_Enter(object sender, EventArgs e)
        {
            ParaGoster(lblParaPower);
            Ekle("Execute ItemGoster " + 3, dgvPower);            /*Power Coin sayfasinda kullanicinin parasini ve pazardaki 
                                                                   * Power coinleri gosterme*/         
        }

        private void RainPage_Enter(object sender, EventArgs e)
        {                       
            ParaGoster(lblparaRain);                             
            Ekle("Execute ItemGoster " + 4, dgvRain);             /*Rain Coin sayfasinda kullanicinin parasini ve pazardaki 
                                                                   * Rain coinleri gosterme*/
        }

        private void RedPage_Enter(object sender, EventArgs e)
        {
            ParaGoster(lblParaRed);
            Ekle("Execute ItemGoster " + 5, dgvRed);              /*Red Coin sayfasinda kullanicinin parasini ve pazardaki 
                                                                   * Red coinleri gosterme*/
        }

        private void SpeedPage_Enter(object sender, EventArgs e)
        {
            ParaGoster(lblParaSpeed);
            Ekle("Execute ItemGoster " + 6, dgvSpeed);             /*Speed Coin sayfasinda kullanicinin parasini ve pazardaki 
                                                                    * Speed coinleri gosterme*/
        }

        private void WinPage_Enter(object sender, EventArgs e)
        {
            ParaGoster(lblParaWin);
            Ekle("Execute ItemGoster " + 7, dgvWin);               /*Win Coin sayfasinda kullanicinin parasini ve pazardaki 
                                                                    * Win coinleri gosterme*/
        }

        private void WolfPage_Enter(object sender, EventArgs e)
        {
            ParaGoster(lblParaWolf);                                  
            Ekle("Execute ItemGoster " + 8, dgvWolf);               /*WolfCoin sayfasinda kullanicinin parasini ve pazardaki 
                                                                     * Wolf coinleri gosterme*/
        }

        private void btnParaEkle_Click(object sender, EventArgs e)
        {
            ParaEkle paraekle = new ParaEkle(kullaniciAdi);
            paraekle.Show();
        }

        private void btnCoinEkle_Click(object sender, EventArgs e)
        {
            CoinEkle coinekle = new CoinEkle(kullaniciAdi);
            coinekle.Show();
        }

        private void btnCuzdan_Click(object sender, EventArgs e)
        {
            Cuzdan cuzdan = new Cuzdan(kullaniciAdi);
            cuzdan.Show();
        }

        private void Anapage_Enter(object sender, EventArgs e)
        {
            ParaGoster(lblPara);
        }

        private void btnAlımBattery_Click(object sender, EventArgs e)
        {
            Satis(1, txtBtryFiyat, txtMiktarBattery, dgvBattery);    
        }

        private void btnAlımBig_Click(object sender, EventArgs e)
        {
            Satis(2, txtBigFiyat, txtMiktarBig, dgvBig);
        }

        private void btnAlımPower_Click(object sender, EventArgs e)
        {
            Satis(3,  txtPwrFiyat, txtMiktarPower, dgvPower);
        }

        private void btnAlımRain_Click(object sender, EventArgs e)
        {
            Satis(4, txtRainFiyat, txtMiktarRain, dgvRain);
        }

        private void btnAlımRed_Click(object sender, EventArgs e)
        {
            Satis(5, txtRedFiyat, txtMiktarRed, dgvRed);
        }

        private void btnAlımSpeed_Click(object sender, EventArgs e)
        {
            Satis(6, txtSpdFiyat , txtMiktarSpeed, dgvSpeed);
        }

        private void btnAlımWin_Click(object sender, EventArgs e)
        {
            Satis(7,  txtWinFiyat, txtMiktarWin, dgvWin);
        }

        private void btnAlımWolf_Click(object sender, EventArgs e)
        {
            Satis(8,  txtWolfFiyat, txtMiktarWolf, dgvWolf);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
