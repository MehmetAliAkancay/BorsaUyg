using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BorsaApplication
{
    class Sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source =.\;Initial Catalog=StockMarketData;Integrated Security=True");
            baglan.Open();
            return baglan;
        }


    }
}
