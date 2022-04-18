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
using System.Xml;

namespace BorsaApplication
{
    public partial class ParaEkle : MetroFramework.Forms.MetroForm
    {
        string kullaniciAdi;
        public ParaEkle(string userid)
        {
            kullaniciAdi = userid;
            InitializeComponent();
        }

        Sqlbaglanti baglanti = new Sqlbaglanti();
        decimal para;
        int itemid;
        private void btnParaEkle_Click(object sender, EventArgs e)
        {
            DovizGoster();
            SqlCommand sqlkomut = new SqlCommand("Select * From Tbl_MoneyTypes Where CurrencyUnit=@p1", baglanti.baglanti());
            sqlkomut.Parameters.AddWithValue("@p1", cmbPara.SelectedItem);      //Combobox taki secilen item aktariliyor.
            SqlDataReader dataReader = sqlkomut.ExecuteReader();

            if (dataReader.Read())
            {
                itemid = Convert.ToInt32(dataReader["MoneyID"]);
            }
            SqlCommand komut =new SqlCommand("Execute ParaEkleme "+"'"+ kullaniciAdi + "'"+","+para.ToString().Replace(',','.')+","+itemid, baglanti.baglanti());
            komut.ExecuteNonQuery();
            MessageBox.Show("Onay için bekleniyor");  //Para Ekleme procedure ile admin sayfasına istenilen para gonderiliyor.
            baglanti.baglanti().Close();
            this.Close();
        }

        private void ParaEkle_Load(object sender, EventArgs e)
        {
            SqlCommand doldur = new SqlCommand("SELECT CurrencyUnit FROM Tbl_MoneyTypes", baglanti.baglanti());
            SqlDataReader dr = doldur.ExecuteReader();
            while (dr.Read())
            {

                cmbPara.Items.Add(dr[0]);   //combobox a Tbl_ıtems daki coin isimleri aktariliyor.
            }
            baglanti.baglanti().Close();
        }
        public void DovizGoster()
        {
            try
            {
                XmlDocument xmlVerisi = new XmlDocument();
                xmlVerisi.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

                decimal dolar = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "USD")).InnerText.Replace('.',','));
                decimal euro = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "EUR")).InnerText.Replace('.', ','));
                decimal sterlin = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "GBP")).InnerText.Replace('.', ','));
                if(cmbPara.SelectedIndex==0)
                {
                    para = Convert.ToDecimal(txtParaEkle.Text) * 1;
                }
                if(cmbPara.SelectedIndex==1)
                {
                    para = Convert.ToDecimal(txtParaEkle.Text) * Convert.ToDecimal(dolar);
                }
                if(cmbPara.SelectedIndex==2)
                {
                    para = Convert.ToDecimal(txtParaEkle.Text) * euro;
                }
                if(cmbPara.SelectedIndex==3)
                {
                    para = Convert.ToDecimal(txtParaEkle.Text) * sterlin;
                }
            }
            catch (XmlException xml)
            {
                MessageBox.Show(xml.ToString());
            }

        }
    }
}
