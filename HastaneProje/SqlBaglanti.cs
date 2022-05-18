using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HastaneProje
{
    internal class SqlBaglanti
    {

        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-O30S5K7;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open();
            return baglan;
        }



    }
}
