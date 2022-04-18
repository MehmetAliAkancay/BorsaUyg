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
    public partial class Rapor : MetroFramework.Forms.MetroForm
    {

        string kullaniciAdi;
        public Rapor(string userid)
        {
            kullaniciAdi = userid;
            InitializeComponent();
        }
        Sqlbaglanti baglanti = new Sqlbaglanti();
        void AlimGoster()
        {
            SqlDataAdapter da = new SqlDataAdapter("Execute RaporAlim " + "'" + dtpBaslangic.Value.ToString("yyyy-MM-dd") + "'" + "," + "'" + dtpBitis.Value.ToString("yyyy-MM-dd") + "'" + "," + "'" + kullaniciAdi + "'", baglanti.baglanti());                        /* Datagridview e itemları yazdırma*/
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAlimRapor.DataSource = dt;
            baglanti.baglanti().Close();

        }
        void AlimExcel()
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;

            object Missing = Type.Missing;
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(Missing);
            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dgvAlimRapor.Columns.Count; j++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dgvAlimRapor.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dgvAlimRapor.Rows.Count; i++)
            {
                for (int j = 0; j < dgvAlimRapor.Columns.Count; j++)
                {
                    try
                    {
                        DataGridViewCell cell = dgvAlimRapor[j, i];
                        sheet1.Cells[i + 2, j + 1] = cell.Value;
                    }
                    catch
                    {
                    }
                }
            }
        }
        void SatimGoster()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("Execute RaporSatim " + "'" + dtpBaslangic.Value.ToString("yyyy-MM-dd") + "'" + "," + "'" + dtpBitis.Value.ToString("yyyy-MM-dd") + "'" + "," + "'" + kullaniciAdi + "'", baglanti.baglanti());                        /* Datagridview e itemları yazdırma*/
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dgvSatimRapor.DataSource = dt1;
            baglanti.baglanti().Close();
        }
        void SatimExcel()
        {

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;

            object Missing = Type.Missing;
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(Missing);
            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dgvSatimRapor.Columns.Count; j++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dgvSatimRapor.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dgvSatimRapor.Rows.Count; i++)
            {
                for (int j = 0; j < dgvSatimRapor.Columns.Count; j++)
                {
                    try
                    {
                        DataGridViewCell cell = dgvSatimRapor[j, i];
                        sheet1.Cells[i + 2, j + 1] = cell.Value;
                    }
                    catch
                    {
                    }
                }
            }
        }
        private void btnRapor_Click(object sender, EventArgs e)
        {

            AlimGoster();
            SatimGoster();
            SatimExcel();
            AlimExcel();
        }
    }
             
    
}

