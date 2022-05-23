using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BimProject.Helpers
{
    public static class MsSQLMarketDal
    {
        public static SqlConnection GetMsSQLConnection()
        {
            SqlConnection conn = new SqlConnection("data source=(localdb)\\MSSQLLocalDB; initial catalog=MarketBim; Trusted_Connection=true");
            return conn;
        }
    }
}
