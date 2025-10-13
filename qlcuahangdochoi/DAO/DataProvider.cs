using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace qlcuahangdochoi.DAO
{
    internal class DataProvider
    {
        static private string strConn = "Data source = DESKTOP-604QTF8\\SQLEXPRESS; Initial Catalog =db_ql_cuahangdochoi1; Integrated Security = true;";

        protected SqlConnection conn = new SqlConnection(strConn);
    }
}
