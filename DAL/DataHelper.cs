using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DataHelper
    {

        private static SqlConnection con = new SqlConnection();
         static DataHelper()
        {
            con.ConnectionString = "Server=.;Database=AyakkabiDB;integrated security=true";
        }
        // static olursa:DAta.helper.TablogEtir();
        public static DataTable TabloGetir(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            DataTable tbl = new DataTable();
            dap.Fill(tbl);
            return tbl;
        }
        public static bool KomutCalistir(string sql,params SqlParameter[] parametreler)
        {
            //ado.net
            con.Open();
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.Parameters.AddRange(parametreler);
            int rows=cmd.ExecuteNonQuery();
            con.Close();
            return rows > 0;
        }
    }
}
