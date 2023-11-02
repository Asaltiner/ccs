using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Dershane
{
    internal class Sqlbaglanti
    {

        public SqlConnection baglanti()
        {

            SqlConnection baglan= new SqlConnection("Data Source=ASALTINER\\SQLEXPRESS;Initial Catalog=DershaneSistemi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
