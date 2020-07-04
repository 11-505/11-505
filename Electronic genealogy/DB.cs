using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronic_genealogy
{
    class DB
    {
        public static DataTable Select(string sql)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection("Data Source = .; Initial Catalog = Genealogy Data; User ID = sa; Password = 123456"))
            {
                SqlDataAdapter data = new SqlDataAdapter(sql, conn);
                data.Fill(dt);
            }
            return dt;
        }
    }
}
