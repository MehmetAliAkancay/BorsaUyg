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
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace BorsaApplication
{
    public partial class Cuzdan : MetroFramework.Forms.MetroForm
    {
        string kullaniciAdi;

        public Cuzdan(string userid)
        {
            InitializeComponent();
            kullaniciAdi = userid;
        }
        Sqlbaglanti baglanti = new Sqlbaglanti();

        private void Cuzdan_Load(object sender, EventArgs e)
        {
            ItemGoster();

        }
        void ItemGoster()
        {
            SqlCommand komut = new SqlCommand("Execute CuzdanItem " + "'" + kullaniciAdi + "'", baglanti.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCuzdan.DataSource = dt;
            baglanti.baglanti().Close();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            Rapor rapor = new Rapor(kullaniciAdi);
            rapor.Show();
        }
    }
}
